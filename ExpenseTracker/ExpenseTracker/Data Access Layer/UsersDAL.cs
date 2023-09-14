using ExpenseTracker.Business_Logic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Data_Access_Layer
{
    internal class UsersDAL
    {
       static string connectionString = ConfigurationManager.ConnectionStrings["ExpenseTrackerDB"].ConnectionString;
       SqlConnection sqlConnection;

        public DataTable getUsers()
        {
            sqlConnection = new SqlConnection(connectionString);

            using(SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users", sqlConnection))
            {
                DataTable queryOut = new DataTable();
                adapter.Fill(queryOut);
                return queryOut;
            }
            
        }

        public string getNameByEmail(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT Name FROM Users WHERE Email=@Email", connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }
            return null; // Return null or handle missing data appropriately
        }

        
    }
}
