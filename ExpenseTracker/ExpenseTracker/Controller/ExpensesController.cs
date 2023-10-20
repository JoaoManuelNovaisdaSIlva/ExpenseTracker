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
            DataTable dt = new DataTable();
            dt = expenses.getUserExpensesService(userId);
            if(dt != null && dt.Rows.Count > 0)
            {
                return dt;
            }else throw new MissingFieldException("The user: " +  userId + "doesn't have any expenses!");
        }
    }
}
