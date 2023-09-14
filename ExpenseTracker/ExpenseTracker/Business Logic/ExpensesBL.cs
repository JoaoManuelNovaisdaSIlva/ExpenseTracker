using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
