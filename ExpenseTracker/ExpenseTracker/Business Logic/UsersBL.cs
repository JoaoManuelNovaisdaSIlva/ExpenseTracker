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

        public UsersBL() { }

        public UsersBL(int userId, string email, string password, string name)
        {
            this.UserId = userId;
            this.email = email;
            this.password = password;
            this.name = name;
        }

        public UsersBL AuthenticationService(string email, string password)
        {
            UsersDAL data = new UsersDAL();
            DataTable users = data.getUsers();

            foreach(DataRow row in users.Rows)
            {
                string tableEmail = row["Email"].ToString();
                string tablePw = row["Password"].ToString();

                if (tableEmail == email && tablePw == password) return new UsersBL(getUserIdByEmailService(email), email, password, getUserByEmailService(email));
            }
            return null;
        }

        public string getUserByEmailService(string email)
        {
            UsersDAL users = new UsersDAL();
            return users.getNameByEmail(email);
        }

        public int getUserIdByEmailService(string email)
        {
            UsersDAL users = new UsersDAL();
            return users.getUserIdByEmail(email);
        }

        public bool addNewUser(string email, string password, string name) {
            UsersDAL usersDAL = new UsersDAL();
            return usersDAL.insertNewUser(email, password, name);
        }

        public string getName() { return this.name; }

        public int getUserId() { return this.UserId; }
    }
}
