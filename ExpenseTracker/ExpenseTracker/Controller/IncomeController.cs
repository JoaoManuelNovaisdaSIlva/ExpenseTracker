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
            if(income != -1)
            {
                return income;
            }else throw new MissingDataException("The user: " +  userId + " has no income!");
        }
           
    }
}
