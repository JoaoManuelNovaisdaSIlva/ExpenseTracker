using ExpenseTracker.Business_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Controller
{
    internal class UserController
    {
        private UsersBL user;

        public UserController()
        {
            this.user = new UsersBL();
        }
        public bool AuthenticateUser(string email, string password)
        {
            return user.AuthenticationService(email, password);
        }

        public string getNameByEmail(string email)
        {
            string str =  user.getUserByEmailService(email);
            if (str == null)
            {
                return "ERROR: Name not found!";
            }
            else return str;
        }

        public string addNewUser(string email, string password, string name) {
            bool result = user.addNewUser(email, password, name);
            if (result)
            {
                return "Success creating new account! \n Go back to the login window to proceed.";
            }
            else return "Error creating account!";
        }
    }
}
