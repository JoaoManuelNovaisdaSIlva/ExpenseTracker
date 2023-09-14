using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Data_Access_Layer;


namespace ExpenseTracker.Business_Logic
{
    internal class UsersBL
    {
        private int UserId { get; set; }
        private string email { get; set; }
        private string password { get; set; }
        private string name { get; set; }

        
        public bool AuthenticationService(string email, string password)
        {
            UsersDAL data = new UsersDAL();
            DataTable users = data.getUsers();

            foreach(DataRow row in users.Rows)
            {
                string tableEmail = row["Email"].ToString();
                string tablePw = row["Password"].ToString();

                if (tableEmail == email && tablePw == password) return true;
            }
            return false;
        }

        public string getUserByEmailService(string email)
        {
            UsersDAL users = new UsersDAL();
            return users.getNameByEmail(email);
        }
    }
}
