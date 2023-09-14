using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Controller
{
    internal class AppController
    {
        public UserController userController;

        public AppController()
        {
            this.userController = new UserController();
        }

        public AppController(UserController userController) { 
            this.userController = userController;
        }
    }
}
