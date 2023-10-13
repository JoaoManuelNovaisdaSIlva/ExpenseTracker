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
        SqlConnection sqlConnection;

        public DataTable getUserExpenses(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand("SELECT * FROM Expenses WHERE User_id=@User_id"))
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
    }
}
