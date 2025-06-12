// Author: David Piggott
// Date: 03/15/2025
// Purpose: Main application form for the budgeting tool. Handles transaction management, filtering, sorting, balance tracking, and exporting.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace BudgetingTool
{
    // Main form for the budgeting tool, managing user interactions and displaying financial data.
    public partial class BudgetingTool : Form
    {
        // Database helper and transaction manager instances.
        private DatabaseHelper dbHelper;
        private TransactionManager transactionManager;
        private List<Transaction> transactions;

        // Initializes the form and loads transactions.
        public BudgetingTool()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            transactionManager = new TransactionManager();
            transactions = new List<Transaction>();

            // Load transactions from the database into the DataGridView.
            LoadTransactions();

            // Assign event handlers to buttons.
            btnAddTransaction.Click += BtnAddTransaction_Click;
            btnDeleteTransaction.Click += BtnDeleteTransaction_Click;
            btnFilterSort.Click += BtnFilterSort_Click;
            btnResetFilters.Click += BtnResetFilters_Click;
        }

        // Loads transactions from the database and updates the DataGridView.
        private void LoadTransactions()
        {
            transactions = dbHelper.GetTransactions();
            transactionManager.LoadTransactions(transactions);
            dgvTransactions.DataSource = null;
            dgvTransactions.DataSource = transactions;

            // Update balance and category trends after loading transactions.
            UpdateBalances();
            UpdateCategoryTrends();
        }

        // Adds a new transaction to the database.
        private void BtnAddTransaction_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem == null || string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please fill in all fields before adding a transaction.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Transaction newTransaction = new Transaction
            {
                Category = cmbCategory.SelectedItem.ToString(),
                Amount = amount,
                Date = dtpDate.Value,
                Memo = txtMemo.Text
            };

            dbHelper.AddTransaction(newTransaction);
            LoadTransactions();
            ClearInputFields();
        }

        // Deletes the selected transaction from the database.
        private void BtnDeleteTransaction_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count == 0 || dgvTransactions.SelectedRows[0].Cells["transactionID"].Value == null)
            {
                MessageBox.Show("Please select a valid transaction to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int transactionID = Convert.ToInt32(dgvTransactions.SelectedRows[0].Cells["transactionID"].Value);
            dbHelper.DeleteTransaction(transactionID);
            LoadTransactions();
        }

        // Clears input fields after adding a transaction.
        private void ClearInputFields()
        {
            cmbCategory.SelectedIndex = -1;
            txtAmount.Clear();
            dtpDate.Value = DateTime.Today;
        }

        // Filters and sorts transactions based on user selection.
        private void BtnFilterSort_Click(object sender, EventArgs e)
        {
            List<Transaction> filteredTransactions = new List<Transaction>(transactions);

            // Apply category filter.
            if (cmbFilterCategory.SelectedItem != null)
            {
                string selectedCategory = cmbFilterCategory.SelectedItem.ToString();
                filteredTransactions = filteredTransactions.Where(t => t.Category.Equals(selectedCategory, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            // Apply date filter.
            filteredTransactions = filteredTransactions
                .Where(t => t.Date >= dtpFilterStartDate.Value && t.Date <= dtpFilterEndDate.Value)
                .ToList();

            // Apply sorting.
            if (cmbSortBy.SelectedItem != null)
            {
                string sortBy = cmbSortBy.SelectedItem.ToString();
                bool ascending = rbSortAscending.Checked;

                if (sortBy == "Amount")
                    filteredTransactions = ascending ? filteredTransactions.OrderBy(t => t.Amount).ToList() : filteredTransactions.OrderByDescending(t => t.Amount).ToList();
                else if (sortBy == "Date")
                    filteredTransactions = ascending ? filteredTransactions.OrderBy(t => t.Date).ToList() : filteredTransactions.OrderByDescending(t => t.Date).ToList();
            }

            dgvTransactions.DataSource = null;
            dgvTransactions.DataSource = filteredTransactions;
        }

        // Resets filters and restores all transactions.
        private void BtnResetFilters_Click(object sender, EventArgs e)
        {
            LoadTransactions();
            cmbFilterCategory.SelectedIndex = -1;
            dtpFilterStartDate.Value = DateTime.Today;
            dtpFilterEndDate.Value = DateTime.Today;
            cmbSortBy.SelectedIndex = -1;
            rbSortAscending.Checked = false;
            rbSortDescending.Checked = false;

            UpdateBalances();
        }

        // Updates category spending trends using progress bars.
        private void UpdateCategoryTrends()
        {
            Dictionary<string, decimal> categoryBudgets = new Dictionary<string, decimal>
            {
                { "Income", 10000m },
                { "Bills", 100000m },
                { "Groceries", 100000m },
                { "Dining Out", 100000m },
                { "Transportation", 100000m },
                { "Entertainment", 100000m },
                { "Savings", 100000m },
                { "Investments", 100000m },
                { "Health", 100000m },
                { "Miscellaneous", 100000m }
            };

            foreach (var category in categoryBudgets.Keys)
            {
                decimal spent = transactions.Where(t => t.Category == category).Sum(t => t.Amount);
                decimal budget = categoryBudgets[category];

                ProgressBar pb = Controls.Find($"progressBar{category.Replace(" ", "")}", true).FirstOrDefault() as ProgressBar;

                if (pb != null)
                {
                    pb.Maximum = (int)budget;
                    pb.Value = (int)Math.Min(spent, budget);
                }

                Label lbl = Controls.Find($"lbl{category.Replace(" ", "")}", true).FirstOrDefault() as Label;

                if (lbl != null)
                {
                    lbl.Text = $"{category}: ${spent} / ${budget}";
                }
            }
        }

        // Updates total balance and low balance warning.
        private void UpdateBalances()
        {
            decimal totalBalance = 0m;

            foreach (var transaction in transactions)
            {
                if (transaction.Category == "Income" || transaction.Category == "Savings" || transaction.Category == "Investments")
                    totalBalance += transaction.Amount;
                else
                    totalBalance -= transaction.Amount;
            }

            lblTotalBalance.Text = $"Total Balance: {totalBalance:C}";

            decimal lowBalanceThreshold = 100m;

            progressBarBalance.Maximum = 10000;
            progressBarBalance.Value = Math.Max(0, Math.Min((int)totalBalance, progressBarBalance.Maximum));

            lblLowBalanceWarning.Text = totalBalance < lowBalanceThreshold ? "⚠ Low Balance!" : "Balance Stable";
            lblLowBalanceWarning.ForeColor = totalBalance < lowBalanceThreshold ? Color.Red : Color.Green;
        }

        // Exports transactions to an Excel file.
        private void ExportToExcel()
        {
            try
            {
                if (dgvTransactions.Rows.Count == 0)
                {
                    MessageBox.Show("No transactions to export!", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx",
                    FileName = $"Transactions_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Transactions");

                        for (int col = 0; col < dgvTransactions.Columns.Count; col++)
                        {
                            worksheet.Cell(1, col + 1).Value = dgvTransactions.Columns[col].HeaderText;
                        }

                        for (int row = 0; row < dgvTransactions.Rows.Count; row++)
                        {
                            for (int col = 0; col < dgvTransactions.Columns.Count; col++)
                            {
                                worksheet.Cell(row + 2, col + 1).Value = dgvTransactions.Rows[row].Cells[col].Value?.ToString() ?? "";
                            }
                        }

                        worksheet.Columns().AdjustToContents();
                        workbook.SaveAs(saveDialog.FileName);
                    }

                    MessageBox.Show("Export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to Excel: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
    }
}
