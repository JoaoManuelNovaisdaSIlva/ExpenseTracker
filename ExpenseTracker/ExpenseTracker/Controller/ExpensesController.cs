using ExpenseTracker.Business_Logic;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Controller
{
    internal class ExpensesController
    {
        private ExpensesBL expenses;

        public ExpensesController() { 
            this.expenses = new ExpensesBL();
        }

        public DataTable getExpensesOfUser(int userId)
        {
            return expenses.getUserExpensesService(userId);
        }
    }
}
