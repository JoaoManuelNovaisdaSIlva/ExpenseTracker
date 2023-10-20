using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Exceptions
{
    public class MissingDataException : Exception
    {
        public MissingDataException() { }

        public MissingDataException(string message) : base(message) { }

        public MissingDataException(string message, Exception innerException) : base(message, innerException) { }
    }
}
