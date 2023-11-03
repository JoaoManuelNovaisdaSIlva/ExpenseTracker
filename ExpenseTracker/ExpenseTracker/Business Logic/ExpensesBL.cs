using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseTracker.Data_Access_Layer;

namespace ExpenseTracker.Business_Logic
{
    internal class ExpensesBL
    {
        private int ExpensesId { get; set; }
        private int User_Id { get; set; }
        private int Category_Id { get; set; }
        private float amount { get; set; }
        private DateTime date { get; set; }
        private string description { get; set; }

        public DataTable getUserExpensesService(int userId)
        {
            ExpensesDAL expenses = new ExpensesDAL();
            return expenses.getUserExpenses(userId);

        }

        public bool addNewExpenseService(int userid, int catid, decimal amount, DateTime date, string disc)
        {
            ExpensesDAL expensesDAL = new ExpensesDAL();
            return expensesDAL.addNewExpense(userid, catid, amount, date, disc);
        }
    }
}
