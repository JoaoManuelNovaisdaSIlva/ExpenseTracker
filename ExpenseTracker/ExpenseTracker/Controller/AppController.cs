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
        public ExpensesController expensesController;

        public AppController()
        {
            this.userController = new UserController();
            this.expensesController = new ExpensesController();
        }

        public AppController(UserController userController, ExpensesController expensesController) { 
            this.userController = userController;
            this.expensesController = expensesController;
        }
    }
}
