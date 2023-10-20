using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Controller
{
    internal class AppController
    {
        private UserController userController;
        private ExpensesController expensesController;
        private CategoriesController categoriesController;
        

        public AppController()
        {
            this.userController = new UserController();
            this.expensesController = new ExpensesController();
            this.categoriesController = new CategoriesController();
        }

        public AppController(UserController userController, ExpensesController expensesController, CategoriesController categoriesController) { 
            this.userController = userController;
            this.expensesController = expensesController;
            this.categoriesController = categoriesController;
        }

        public UserController getUserController()
        {
            return this.userController;
        }

        public ExpensesController getExpensesController()
        {
            return this.expensesController;
        }

        public CategoriesController getCategoriesController()
        {
            return categoriesController;
        }
    }
}
