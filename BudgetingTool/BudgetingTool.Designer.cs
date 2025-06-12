namespace BudgetingTool
{
    partial class BudgetingTool
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpTransactionInput = new GroupBox();
            txtMemo = new TextBox();
            lblMemo = new Label();
            btnAddTransaction = new Button();
            dtpDate = new DateTimePicker();
            lblDate = new Label();
            txtAmount = new TextBox();
            lblAmount = new Label();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            grpTransactionControls = new GroupBox();
            btnExportToExcel = new Button();
            rbSortDescending = new RadioButton();
            rbSortAscending = new RadioButton();
            cmbSortBy = new ComboBox();
            lblSortBy = new Label();
            dtpFilterEndDate = new DateTimePicker();
            lblFilterEndDate = new Label();
            lblFilterStartDate = new Label();
            dtpFilterStartDate = new DateTimePicker();
            lblFilterCategory = new Label();
            cmbFilterCategory = new ComboBox();
            btnResetFilters = new Button();
            btnFilterSort = new Button();
            btnDeleteTransaction = new Button();
            grpTransactions = new GroupBox();
            progressBarBalance = new ProgressBar();
            lblLowBalanceWarning = new Label();
            lblTotalBalance = new Label();
            dgvTransactions = new DataGridView();
            transactionID = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            memo = new DataGridViewTextBoxColumn();
            grpSpendingTrends = new GroupBox();
            lblMiscellaneous = new Label();
            lblHealth = new Label();
            lblInvestments = new Label();
            lblSavings = new Label();
            lblEntertainment = new Label();
            lblTransportation = new Label();
            lblDiningOut = new Label();
            lblGroceries = new Label();
            lblBills = new Label();
            lblIncome = new Label();
            progressBarHealth = new ProgressBar();
            progressBarMiscellaneous = new ProgressBar();
            progressBarInvestments = new ProgressBar();
            progressBarSavings = new ProgressBar();
            progressBarDiningOut = new ProgressBar();
            progressBarEntertainment = new ProgressBar();
            progressBarTransportation = new ProgressBar();
            progressBarBills = new ProgressBar();
            progressBarGroceries = new ProgressBar();
            progressBarIncome = new ProgressBar();
            grpTransactionInput.SuspendLayout();
            grpTransactionControls.SuspendLayout();
            grpTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            grpSpendingTrends.SuspendLayout();
            SuspendLayout();
            // 
            // grpTransactionInput
            // 
            grpTransactionInput.Controls.Add(txtMemo);
            grpTransactionInput.Controls.Add(lblMemo);
            grpTransactionInput.Controls.Add(btnAddTransaction);
            grpTransactionInput.Controls.Add(dtpDate);
            grpTransactionInput.Controls.Add(lblDate);
            grpTransactionInput.Controls.Add(txtAmount);
            grpTransactionInput.Controls.Add(lblAmount);
            grpTransactionInput.Controls.Add(cmbCategory);
            grpTransactionInput.Controls.Add(lblCategory);
            grpTransactionInput.Location = new Point(12, 12);
            grpTransactionInput.Name = "grpTransactionInput";
            grpTransactionInput.Size = new Size(415, 556);
            grpTransactionInput.TabIndex = 0;
            grpTransactionInput.TabStop = false;
            grpTransactionInput.Text = "Transaction Input";
            // 
            // txtMemo
            // 
            txtMemo.Location = new Point(122, 145);
            txtMemo.Name = "txtMemo";
            txtMemo.Size = new Size(287, 23);
            txtMemo.TabIndex = 8;
            // 
            // lblMemo
            // 
            lblMemo.AutoSize = true;
            lblMemo.Location = new Point(6, 148);
            lblMemo.Name = "lblMemo";
            lblMemo.Size = new Size(45, 15);
            lblMemo.TabIndex = 7;
            lblMemo.Text = "Memo:";
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.Location = new Point(122, 189);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.Size = new Size(107, 23);
            btnAddTransaction.TabIndex = 6;
            btnAddTransaction.Text = "Add Transaction";
            btnAddTransaction.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(122, 109);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(287, 23);
            dtpDate.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(6, 115);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(34, 15);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(122, 76);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(287, 23);
            txtAmount.TabIndex = 3;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(6, 76);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(110, 15);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Amount: (XXXX.XX)";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Income", "Bills", "Groceries", "Dining Out", "Transportation", "Entertainment", "Savings", "Investments", "Health", "Miscellaneous" });
            cmbCategory.Location = new Point(122, 40);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(287, 23);
            cmbCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(6, 43);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category:";
            // 
            // grpTransactionControls
            // 
            grpTransactionControls.Controls.Add(btnExportToExcel);
            grpTransactionControls.Controls.Add(rbSortDescending);
            grpTransactionControls.Controls.Add(rbSortAscending);
            grpTransactionControls.Controls.Add(cmbSortBy);
            grpTransactionControls.Controls.Add(lblSortBy);
            grpTransactionControls.Controls.Add(dtpFilterEndDate);
            grpTransactionControls.Controls.Add(lblFilterEndDate);
            grpTransactionControls.Controls.Add(lblFilterStartDate);
            grpTransactionControls.Controls.Add(dtpFilterStartDate);
            grpTransactionControls.Controls.Add(lblFilterCategory);
            grpTransactionControls.Controls.Add(cmbFilterCategory);
            grpTransactionControls.Controls.Add(btnResetFilters);
            grpTransactionControls.Controls.Add(btnFilterSort);
            grpTransactionControls.Controls.Add(btnDeleteTransaction);
            grpTransactionControls.Location = new Point(433, 12);
            grpTransactionControls.Name = "grpTransactionControls";
            grpTransactionControls.Size = new Size(371, 556);
            grpTransactionControls.TabIndex = 1;
            grpTransactionControls.TabStop = false;
            grpTransactionControls.Text = "Transacton Controls";
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.Location = new Point(128, 412);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(121, 23);
            btnExportToExcel.TabIndex = 14;
            btnExportToExcel.Text = "Export to Excel";
            btnExportToExcel.UseVisualStyleBackColor = true;
            btnExportToExcel.Click += btnExportToExcel_Click;
            // 
            // rbSortDescending
            // 
            rbSortDescending.AutoSize = true;
            rbSortDescending.Location = new Point(240, 271);
            rbSortDescending.Name = "rbSortDescending";
            rbSortDescending.Size = new Size(87, 19);
            rbSortDescending.TabIndex = 13;
            rbSortDescending.TabStop = true;
            rbSortDescending.Text = "Descending";
            rbSortDescending.UseVisualStyleBackColor = true;
            // 
            // rbSortAscending
            // 
            rbSortAscending.AutoSize = true;
            rbSortAscending.Location = new Point(127, 271);
            rbSortAscending.Name = "rbSortAscending";
            rbSortAscending.Size = new Size(81, 19);
            rbSortAscending.TabIndex = 12;
            rbSortAscending.TabStop = true;
            rbSortAscending.Text = "Ascending";
            rbSortAscending.UseVisualStyleBackColor = true;
            // 
            // cmbSortBy
            // 
            cmbSortBy.FormattingEnabled = true;
            cmbSortBy.Items.AddRange(new object[] { "Amount", "Date", "Category" });
            cmbSortBy.Location = new Point(127, 234);
            cmbSortBy.Name = "cmbSortBy";
            cmbSortBy.Size = new Size(201, 23);
            cmbSortBy.TabIndex = 11;
            // 
            // lblSortBy
            // 
            lblSortBy.AutoSize = true;
            lblSortBy.Location = new Point(6, 234);
            lblSortBy.Name = "lblSortBy";
            lblSortBy.Size = new Size(47, 15);
            lblSortBy.TabIndex = 10;
            lblSortBy.Text = "Sort By:";
            // 
            // dtpFilterEndDate
            // 
            dtpFilterEndDate.Location = new Point(127, 197);
            dtpFilterEndDate.Name = "dtpFilterEndDate";
            dtpFilterEndDate.Size = new Size(201, 23);
            dtpFilterEndDate.TabIndex = 9;
            // 
            // lblFilterEndDate
            // 
            lblFilterEndDate.AutoSize = true;
            lblFilterEndDate.Location = new Point(6, 197);
            lblFilterEndDate.Name = "lblFilterEndDate";
            lblFilterEndDate.Size = new Size(57, 15);
            lblFilterEndDate.TabIndex = 8;
            lblFilterEndDate.Text = "End Date:";
            // 
            // lblFilterStartDate
            // 
            lblFilterStartDate.AutoSize = true;
            lblFilterStartDate.Location = new Point(6, 162);
            lblFilterStartDate.Name = "lblFilterStartDate";
            lblFilterStartDate.Size = new Size(61, 15);
            lblFilterStartDate.TabIndex = 7;
            lblFilterStartDate.Text = "Start Date:";
            // 
            // dtpFilterStartDate
            // 
            dtpFilterStartDate.Location = new Point(128, 162);
            dtpFilterStartDate.Name = "dtpFilterStartDate";
            dtpFilterStartDate.Size = new Size(200, 23);
            dtpFilterStartDate.TabIndex = 6;
            // 
            // lblFilterCategory
            // 
            lblFilterCategory.AutoSize = true;
            lblFilterCategory.Location = new Point(6, 130);
            lblFilterCategory.Name = "lblFilterCategory";
            lblFilterCategory.Size = new Size(103, 15);
            lblFilterCategory.TabIndex = 5;
            lblFilterCategory.Text = "Filter by Category:";
            // 
            // cmbFilterCategory
            // 
            cmbFilterCategory.FormattingEnabled = true;
            cmbFilterCategory.Items.AddRange(new object[] { "Income", "Bills", "Groceries", "Dining Out", "Transportation", "Entertainment", "Savings", "Investments", "Health", "Miscellaneous" });
            cmbFilterCategory.Location = new Point(127, 127);
            cmbFilterCategory.Name = "cmbFilterCategory";
            cmbFilterCategory.Size = new Size(201, 23);
            cmbFilterCategory.TabIndex = 4;
            // 
            // btnResetFilters
            // 
            btnResetFilters.Location = new Point(128, 354);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(122, 23);
            btnResetFilters.TabIndex = 3;
            btnResetFilters.Text = "Reset Filters";
            btnResetFilters.UseVisualStyleBackColor = true;
            // 
            // btnFilterSort
            // 
            btnFilterSort.Location = new Point(127, 315);
            btnFilterSort.Name = "btnFilterSort";
            btnFilterSort.Size = new Size(122, 23);
            btnFilterSort.TabIndex = 2;
            btnFilterSort.Text = "Filter/Sort";
            btnFilterSort.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTransaction
            // 
            btnDeleteTransaction.Location = new Point(127, 57);
            btnDeleteTransaction.Name = "btnDeleteTransaction";
            btnDeleteTransaction.Size = new Size(122, 23);
            btnDeleteTransaction.TabIndex = 0;
            btnDeleteTransaction.Text = "Delete Transaction";
            btnDeleteTransaction.UseVisualStyleBackColor = true;
            // 
            // grpTransactions
            // 
            grpTransactions.Controls.Add(progressBarBalance);
            grpTransactions.Controls.Add(lblLowBalanceWarning);
            grpTransactions.Controls.Add(lblTotalBalance);
            grpTransactions.Controls.Add(dgvTransactions);
            grpTransactions.Location = new Point(810, 12);
            grpTransactions.Name = "grpTransactions";
            grpTransactions.Size = new Size(575, 556);
            grpTransactions.TabIndex = 2;
            grpTransactions.TabStop = false;
            grpTransactions.Text = "Transactions Display";
            // 
            // progressBarBalance
            // 
            progressBarBalance.Location = new Point(15, 491);
            progressBarBalance.Name = "progressBarBalance";
            progressBarBalance.Size = new Size(255, 49);
            progressBarBalance.TabIndex = 3;
            // 
            // lblLowBalanceWarning
            // 
            lblLowBalanceWarning.AutoSize = true;
            lblLowBalanceWarning.Location = new Point(15, 457);
            lblLowBalanceWarning.Name = "lblLowBalanceWarning";
            lblLowBalanceWarning.Size = new Size(76, 15);
            lblLowBalanceWarning.TabIndex = 2;
            lblLowBalanceWarning.Text = "Low Balance:";
            // 
            // lblTotalBalance
            // 
            lblTotalBalance.AutoSize = true;
            lblTotalBalance.Location = new Point(15, 420);
            lblTotalBalance.Name = "lblTotalBalance";
            lblTotalBalance.Size = new Size(80, 15);
            lblTotalBalance.TabIndex = 1;
            lblTotalBalance.Text = "Total Balance:";
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToOrderColumns = true;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Columns.AddRange(new DataGridViewColumn[] { transactionID, category, amount, date, memo });
            dgvTransactions.Location = new Point(15, 40);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.Size = new Size(545, 367);
            dgvTransactions.TabIndex = 0;
            // 
            // transactionID
            // 
            transactionID.DataPropertyName = "ID";
            transactionID.HeaderText = "ID";
            transactionID.Name = "transactionID";
            // 
            // category
            // 
            category.DataPropertyName = "Category";
            category.HeaderText = "Category";
            category.Name = "category";
            // 
            // amount
            // 
            amount.DataPropertyName = "Amount";
            amount.HeaderText = "Amount";
            amount.Name = "amount";
            // 
            // date
            // 
            date.DataPropertyName = "Date";
            date.HeaderText = "Date";
            date.Name = "date";
            // 
            // memo
            // 
            memo.DataPropertyName = "Memo";
            memo.HeaderText = "Memo";
            memo.Name = "memo";
            // 
            // grpSpendingTrends
            // 
            grpSpendingTrends.Controls.Add(lblMiscellaneous);
            grpSpendingTrends.Controls.Add(lblHealth);
            grpSpendingTrends.Controls.Add(lblInvestments);
            grpSpendingTrends.Controls.Add(lblSavings);
            grpSpendingTrends.Controls.Add(lblEntertainment);
            grpSpendingTrends.Controls.Add(lblTransportation);
            grpSpendingTrends.Controls.Add(lblDiningOut);
            grpSpendingTrends.Controls.Add(lblGroceries);
            grpSpendingTrends.Controls.Add(lblBills);
            grpSpendingTrends.Controls.Add(lblIncome);
            grpSpendingTrends.Controls.Add(progressBarHealth);
            grpSpendingTrends.Controls.Add(progressBarMiscellaneous);
            grpSpendingTrends.Controls.Add(progressBarInvestments);
            grpSpendingTrends.Controls.Add(progressBarSavings);
            grpSpendingTrends.Controls.Add(progressBarDiningOut);
            grpSpendingTrends.Controls.Add(progressBarEntertainment);
            grpSpendingTrends.Controls.Add(progressBarTransportation);
            grpSpendingTrends.Controls.Add(progressBarBills);
            grpSpendingTrends.Controls.Add(progressBarGroceries);
            grpSpendingTrends.Controls.Add(progressBarIncome);
            grpSpendingTrends.Location = new Point(27, 585);
            grpSpendingTrends.Name = "grpSpendingTrends";
            grpSpendingTrends.Size = new Size(1358, 159);
            grpSpendingTrends.TabIndex = 3;
            grpSpendingTrends.TabStop = false;
            grpSpendingTrends.Text = "Spending Trends";
            // 
            // lblMiscellaneous
            // 
            lblMiscellaneous.AutoSize = true;
            lblMiscellaneous.Location = new Point(1048, 86);
            lblMiscellaneous.Name = "lblMiscellaneous";
            lblMiscellaneous.Size = new Size(82, 15);
            lblMiscellaneous.TabIndex = 19;
            lblMiscellaneous.Text = "Miscellaneous";
            // 
            // lblHealth
            // 
            lblHealth.AutoSize = true;
            lblHealth.Location = new Point(1048, 23);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(42, 15);
            lblHealth.TabIndex = 18;
            lblHealth.Text = "Health";
            // 
            // lblInvestments
            // 
            lblInvestments.AutoSize = true;
            lblInvestments.Location = new Point(791, 86);
            lblInvestments.Name = "lblInvestments";
            lblInvestments.Size = new Size(71, 15);
            lblInvestments.TabIndex = 17;
            lblInvestments.Text = "Investments";
            // 
            // lblSavings
            // 
            lblSavings.AutoSize = true;
            lblSavings.Location = new Point(791, 23);
            lblSavings.Name = "lblSavings";
            lblSavings.Size = new Size(47, 15);
            lblSavings.TabIndex = 16;
            lblSavings.Text = "Savings";
            // 
            // lblEntertainment
            // 
            lblEntertainment.AutoSize = true;
            lblEntertainment.Location = new Point(532, 86);
            lblEntertainment.Name = "lblEntertainment";
            lblEntertainment.Size = new Size(82, 15);
            lblEntertainment.TabIndex = 15;
            lblEntertainment.Text = "Entertainment";
            // 
            // lblTransportation
            // 
            lblTransportation.AutoSize = true;
            lblTransportation.Location = new Point(534, 23);
            lblTransportation.Name = "lblTransportation";
            lblTransportation.Size = new Size(84, 15);
            lblTransportation.TabIndex = 14;
            lblTransportation.Text = "Transportation";
            // 
            // lblDiningOut
            // 
            lblDiningOut.AutoSize = true;
            lblDiningOut.Location = new Point(275, 86);
            lblDiningOut.Name = "lblDiningOut";
            lblDiningOut.Size = new Size(65, 15);
            lblDiningOut.TabIndex = 13;
            lblDiningOut.Text = "Dining Out";
            // 
            // lblGroceries
            // 
            lblGroceries.AutoSize = true;
            lblGroceries.Location = new Point(275, 23);
            lblGroceries.Name = "lblGroceries";
            lblGroceries.Size = new Size(56, 15);
            lblGroceries.TabIndex = 12;
            lblGroceries.Text = "Groceries";
            // 
            // lblBills
            // 
            lblBills.AutoSize = true;
            lblBills.Location = new Point(18, 86);
            lblBills.Name = "lblBills";
            lblBills.Size = new Size(28, 15);
            lblBills.TabIndex = 11;
            lblBills.Text = "Bills";
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Location = new Point(18, 23);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(47, 15);
            lblIncome.TabIndex = 10;
            lblIncome.Text = "Income";
            // 
            // progressBarHealth
            // 
            progressBarHealth.Location = new Point(1048, 41);
            progressBarHealth.Name = "progressBarHealth";
            progressBarHealth.Size = new Size(251, 23);
            progressBarHealth.TabIndex = 9;
            // 
            // progressBarMiscellaneous
            // 
            progressBarMiscellaneous.Location = new Point(1048, 104);
            progressBarMiscellaneous.Name = "progressBarMiscellaneous";
            progressBarMiscellaneous.Size = new Size(251, 23);
            progressBarMiscellaneous.TabIndex = 8;
            // 
            // progressBarInvestments
            // 
            progressBarInvestments.Location = new Point(791, 104);
            progressBarInvestments.Name = "progressBarInvestments";
            progressBarInvestments.Size = new Size(251, 23);
            progressBarInvestments.TabIndex = 7;
            // 
            // progressBarSavings
            // 
            progressBarSavings.Location = new Point(791, 41);
            progressBarSavings.Name = "progressBarSavings";
            progressBarSavings.Size = new Size(251, 23);
            progressBarSavings.TabIndex = 6;
            // 
            // progressBarDiningOut
            // 
            progressBarDiningOut.Location = new Point(275, 104);
            progressBarDiningOut.Name = "progressBarDiningOut";
            progressBarDiningOut.Size = new Size(251, 23);
            progressBarDiningOut.TabIndex = 5;
            // 
            // progressBarEntertainment
            // 
            progressBarEntertainment.Location = new Point(534, 104);
            progressBarEntertainment.Name = "progressBarEntertainment";
            progressBarEntertainment.Size = new Size(251, 23);
            progressBarEntertainment.TabIndex = 4;
            // 
            // progressBarTransportation
            // 
            progressBarTransportation.Location = new Point(534, 41);
            progressBarTransportation.Name = "progressBarTransportation";
            progressBarTransportation.Size = new Size(251, 23);
            progressBarTransportation.TabIndex = 3;
            // 
            // progressBarBills
            // 
            progressBarBills.Location = new Point(18, 104);
            progressBarBills.Name = "progressBarBills";
            progressBarBills.Size = new Size(251, 23);
            progressBarBills.TabIndex = 2;
            // 
            // progressBarGroceries
            // 
            progressBarGroceries.Location = new Point(275, 41);
            progressBarGroceries.Name = "progressBarGroceries";
            progressBarGroceries.Size = new Size(251, 23);
            progressBarGroceries.TabIndex = 1;
            // 
            // progressBarIncome
            // 
            progressBarIncome.Location = new Point(18, 41);
            progressBarIncome.Name = "progressBarIncome";
            progressBarIncome.Size = new Size(251, 23);
            progressBarIncome.TabIndex = 0;
            // 
            // BudgetingTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 756);
            Controls.Add(grpSpendingTrends);
            Controls.Add(grpTransactions);
            Controls.Add(grpTransactionControls);
            Controls.Add(grpTransactionInput);
            Name = "BudgetingTool";
            Text = "Budgeting Tool";
            grpTransactionInput.ResumeLayout(false);
            grpTransactionInput.PerformLayout();
            grpTransactionControls.ResumeLayout(false);
            grpTransactionControls.PerformLayout();
            grpTransactions.ResumeLayout(false);
            grpTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            grpSpendingTrends.ResumeLayout(false);
            grpSpendingTrends.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTransactionInput;
        private GroupBox grpTransactionControls;
        private GroupBox grpTransactions;
        private Button btnAddTransaction;
        private DateTimePicker dtpDate;
        private Label lblDate;
        private TextBox txtAmount;
        private Label lblAmount;
        private ComboBox cmbCategory;
        private Label lblCategory;
        private Button btnDeleteTransaction;
        private Button btnResetFilters;
        private Button btnFilterSort;
        private Label lblLowBalanceWarning;
        private Label lblTotalBalance;
        private DataGridView dgvTransactions;
        private Label lblFilterStartDate;
        private DateTimePicker dtpFilterStartDate;
        private Label lblFilterCategory;
        private ComboBox cmbFilterCategory;
        private ProgressBar progressBarBalance;
        private RadioButton rbSortDescending;
        private RadioButton rbSortAscending;
        private ComboBox cmbSortBy;
        private Label lblSortBy;
        private DateTimePicker dtpFilterEndDate;
        private Label lblFilterEndDate;
        private TextBox txtMemo;
        private Label lblMemo;
        private DataGridViewTextBoxColumn transactionID;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn memo;
        private GroupBox grpSpendingTrends;
        private ProgressBar progressBarHealth;
        private ProgressBar progressBarMiscellaneous;
        private ProgressBar progressBarInvestments;
        private ProgressBar progressBarSavings;
        private ProgressBar progressBarDiningOut;
        private ProgressBar progressBarEntertainment;
        private ProgressBar progressBarTransportation;
        private ProgressBar progressBarBills;
        private ProgressBar progressBarGroceries;
        private ProgressBar progressBarIncome;
        private Label lblMiscellaneous;
        private Label lblHealth;
        private Label lblInvestments;
        private Label lblSavings;
        private Label lblEntertainment;
        private Label lblTransportation;
        private Label lblDiningOut;
        private Label lblGroceries;
        private Label lblBills;
        private Label lblIncome;
        private Button btnExportToExcel;
    }
}
