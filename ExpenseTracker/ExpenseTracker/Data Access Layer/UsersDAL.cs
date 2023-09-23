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
                    command.Parameters.AddWithValue("@Email", email); // Parameters avoid SQL injections
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }
            return null; // Return null or handle missing data appropriately
        }

        public bool insertNewUser(string email, string password, string name)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand("INSERT INTO Users (Email, Name, Password) VALUES (@Email, @Name, @Password)", connection))
                {
                    command.Parameters.AddWithValue ("@Email", email); // Parameters avoid SQL injections
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue ("@Password", password);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        
    }
}
