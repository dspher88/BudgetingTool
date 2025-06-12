// Author: David Piggott
// Date: 03/15/2025
// Purpose: Represents a single financial transaction in the budgeting tool.

using System;

namespace BudgetingTool
{
    // Defines the structure of a financial transaction.
    public class Transaction
    {
        // Unique identifier for the transaction.
        public int ID { get; set; }

        // Category of the transaction (e.g., Income, Bills, Groceries).
        public string Category { get; set; }

        // Amount associated with the transaction.
        public decimal Amount { get; set; }

        // Date when the transaction occurred.
        public DateTime Date { get; set; }

        // Additional notes or details about the transaction.
        public string Memo { get; set; }
    }
}
