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
        private IncomeController incomeController;
        

        public AppController()
        {
            this.userController = new UserController();
            this.expensesController = new ExpensesController();
            this.categoriesController = new CategoriesController();
            this.incomeController = new IncomeController();
        }

        public AppController(UserController userController, ExpensesController expensesController, CategoriesController categoriesController, IncomeController income) { 
            this.userController = userController;
            this.expensesController = expensesController;
            this.categoriesController = categoriesController;
            this.incomeController = income;
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
            return this.categoriesController;
        }

        public IncomeController getIncomeController()
        {
            return this.incomeController;
        }
    }
}
