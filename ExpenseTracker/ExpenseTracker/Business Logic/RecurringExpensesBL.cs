using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Frequency
{
    Recurring,
    DateLimited,
    RepetitionLimited
}

namespace ExpenseTracker.Business_Logic
{
    internal class RecurringExpensesBL : ExpensesBL
    {
        private Frequency frequency;

        
    }
}
