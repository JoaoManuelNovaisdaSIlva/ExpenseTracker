using ExpenseTracker.Business_Logic;
using ExpenseTracker.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Controller
{
    internal class IncomeController
    {
        private IncomeBL incomeBL;

        public IncomeController()
        {
            this.incomeBL = new IncomeBL();
        }

        public decimal getMonthsIncome(int userId, DateTime date)
        {
            Decimal income = incomeBL.getMonthsIncomeService(userId, date);
            return income; // returns -1 if user has no income
        }
           
        public string addNewIncome(int userId, decimal income, DateTime date) {
            bool result = incomeBL.addNewIncomeService(userId, income, date);
            if (result)
            {
                return "New income add with sucess! \n Return to previouse menu to proceed.";
            }
            else return "There was an error when adding the new income!";
        }

    }
}
