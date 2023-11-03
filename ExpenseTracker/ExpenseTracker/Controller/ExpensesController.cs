using ExpenseTracker.Business_Logic;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Exceptions;

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
            DataTable dt = new DataTable();
            dt = expenses.getUserExpensesService(userId);
            return dt;
        }

        public string addNewExpense(int userId, int catId, decimal amount, DateTime date, string disc)
        {
            bool result = expenses.addNewExpenseService(userId, catId, amount, date, disc);
            if(result)
            {
                return "New expense added with sucess! \n Return to previouse menu to proceed.";
            }
            else return "There was an error adding the new expense!";
        }
    }
}
