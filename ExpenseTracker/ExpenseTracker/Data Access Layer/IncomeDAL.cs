using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Data_Access_Layer
{
    internal class IncomeDAL
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["ExpenseTrackerDB"].ConnectionString;

        public decimal getMonthsIncome(int userId, DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(
                    "SELECT SUM(amount) AS TotalIncome " +
                    "FROM Income " +
                    "WHERE User_Id = @UserId " +
                    "AND Date = @Date;", connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@Date", date);

                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal totalIncome = Convert.ToDecimal(result);
                        return totalIncome;
                    }
                    else return -1;
                    
                }

            }
        }
    }
}
