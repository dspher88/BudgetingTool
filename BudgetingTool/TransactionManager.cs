// Author: David Piggott
// Date: 03/15/2025
// Purpose: Handles filtering and sorting logic for financial transactions.

using System;
using System.Collections.Generic;
using System.Linq;

namespace BudgetingTool
{
    // Manages transaction filtering and sorting operations.
    public class TransactionManager
    {
        // Stores the list of transactions for filtering and sorting.
        private List<Transaction> transactions = new List<Transaction>();

        // Loads transactions from the database into the manager.
        public void LoadTransactions(List<Transaction> loadedTransactions)
        {
            transactions = loadedTransactions;
        }

        // Filters transactions based on the specified category.
        public List<Transaction> FilterByCategory(string category)
        {
            return transactions.Where(t => t.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // Sorts transactions by amount in ascending or descending order.
        public List<Transaction> SortByAmount(bool ascending = true)
        {
            return ascending ? transactions.OrderBy(t => t.Amount).ToList() : transactions.OrderByDescending(t => t.Amount).ToList();
        }

        // Sorts transactions by date in ascending or descending order.
        public List<Transaction> SortByDate(bool ascending = true)
        {
            return ascending ? transactions.OrderBy(t => t.Date).ToList() : transactions.OrderByDescending(t => t.Date).ToList();
        }
    }
}

