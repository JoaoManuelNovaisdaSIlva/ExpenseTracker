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

        public DataTable getUsers()
        {
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users", sqlConnection))
                {
                    DataTable queryOut = new DataTable();
                    adapter.Fill(queryOut);
                    return queryOut;
                }
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

        public int getUserIdByEmail(string email)
        {
            using (SqlConnection connection = new SqlConnection( connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT UserId FROM Users WHERE Email=@Email", connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    object result = command.ExecuteScalar();
                    if(result != null)
                    {
                        return (int)result;
                    }
                }
            }
            return -1;
        }

        public bool insertNewUser(string email, string password, string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if a user with the same email already exists
                using (SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Email = @Email", connection))
                {
                    checkCommand.Parameters.AddWithValue("@Email", email);
                    int existingUserCount = (int)checkCommand.ExecuteScalar();

                    if (existingUserCount > 0)
                    {
                        // A user with the same email already exists; handle this situation
                        return false;
                    }
                }

                // If there's no existing user with the same email, proceed with the insertion
                using (SqlCommand insertCommand = new SqlCommand("INSERT INTO Users (Email, Name, Password) VALUES (@Email, @Name, @Password)", connection))
                {
                    insertCommand.Parameters.AddWithValue("@Email", email);
                    insertCommand.Parameters.AddWithValue("@Name", name);
                    insertCommand.Parameters.AddWithValue("@Password", password);

                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }



    }
}
