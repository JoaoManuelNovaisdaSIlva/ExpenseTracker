using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Data_Access_Layer
{
    internal class ExpensesDAL
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["ExpenseTrackerDB"].ConnectionString;

        public DataTable getUserExpenses(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand("SELECT * FROM Expenses WHERE User_id=@User_id", connection))
                {
                    command.Parameters.AddWithValue("@User_id", id);

                    DataTable userExpenses = new DataTable();
                    using(SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(userExpenses);
                    }
                    return userExpenses;
                }
            }

        }
        public bool addNewExpense(int userId, int categoryId, decimal amount, DateTime date, string description)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand("INSERT INTO Expenses (User_Id, Category_Id, Amount, Date, Description) VALUES (@User_Id, @Category_Id, @Amount, @Date, @Description)", connection))
                {
                    command.Parameters.AddWithValue("@User_Id", userId);
                    command.Parameters.AddWithValue("@Category_Id", categoryId);
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@Description", description);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
