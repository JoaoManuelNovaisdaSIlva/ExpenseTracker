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
    internal class CategoriesDAL
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["ExpenseTrackerDB"].ConnectionString;

        public DataTable getAllCategories()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using(SqlCommand command = new SqlCommand("SELECT * FROM Categories", sqlConnection)) {
                    DataTable dataTable = new DataTable();
                    using(SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    return dataTable;
                }
            }
        }

        public bool addNewCategory(string categoryName)
        {
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using(SqlCommand  cmd = new SqlCommand("SELECT COUNT(*) FROM Categories WHERE CategoryName = @CategoryName", sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                    int existingCat = (int)cmd.ExecuteScalar();
                    if (existingCat > 0) return false;
                }

                using(SqlCommand cmdInset = new SqlCommand("INSERT INTO Categories (CategoryName) VALUES (@CategoryName)", sqlConnection))
                {
                    cmdInset.Parameters.AddWithValue("@CategoryName", categoryName);

                    int rowsAffected = cmdInset.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool removeCategory(string categoryName)
        {
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using(SqlCommand cmd = new SqlCommand("DELETE FROM Categories WHERE CategoryName = @CategoryName", sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
