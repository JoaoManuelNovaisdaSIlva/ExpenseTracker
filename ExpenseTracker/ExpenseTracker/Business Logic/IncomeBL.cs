using ExpenseTracker.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Business_Logic
{
    internal class IncomeBL
    {
        private int incomeId;
        private int userId;
        private decimal amount;
        private DateTime date;

        public decimal getMonthsIncomeService(int userId, DateTime date)
        {
            IncomeDAL incomeDAL = new IncomeDAL();
            return incomeDAL.getMonthsIncome(userId, date);
        }
    }
}
