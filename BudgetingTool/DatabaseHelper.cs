using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace BudgetingTool
{
    public class DatabaseHelper
    {
        // Opens and returns an active database connection dynamically
        private SqlConnection OpenDBConnection()
        {
            // Get the base directory of the application 
            string path = Application.StartupPath;
            path = path.Substring(0, path.LastIndexOf("bin")); 

            // Append the database file name
            string dbFilePath = Path.Combine(path, "BudgetingTool.mdf");

            // Create a connection string dynamically
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbFilePath};Integrated Security=True";

            // Establish and open the database connection
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            return dbConnection;
        }

        // Adds a new transaction to the database.
        public void AddTransaction(Transaction transaction)
        {
            using (SqlConnection conn = OpenDBConnection())
            {
                string query = "INSERT INTO Transactions (Category, Amount, Date, Memo) VALUES (@Category, @Amount, @Date, @Memo)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Category", transaction.Category);
                    cmd.Parameters.AddWithValue("@Amount", transaction.Amount);
                    cmd.Parameters.AddWithValue("@Date", transaction.Date);
                    cmd.Parameters.AddWithValue("@Memo", transaction.Memo ?? (object)DBNull.Value); // Handles null values
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Deletes a transaction from the database.
        public void DeleteTransaction(int transactionID)
        {
            using (SqlConnection conn = OpenDBConnection())
            {
                string query = "DELETE FROM Transactions WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = transactionID;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Retrieves all transactions from the database.
        public List<Transaction> GetTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();
            using (SqlConnection conn = OpenDBConnection())
            {
                string query = "SELECT ID, Category, Amount, Date, Memo FROM Transactions";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transactions.Add(new Transaction
                            {
                                ID = reader.GetInt32(0),
                                Category = reader.GetString(1),
                                Amount = reader.GetDecimal(2),
                                Date = reader.GetDateTime(3),
                                Memo = reader.IsDBNull(4) ? "" : reader.GetString(4)
                            });
                        }
                    }
                }
            }
            return transactions;
        }
    }
}