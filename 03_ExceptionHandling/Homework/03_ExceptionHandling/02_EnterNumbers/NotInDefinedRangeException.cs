using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EnterNumbers
{
    class NotInDefinedRangeException : Exception
    {
        public NotInDefinedRangeException(string message)
            : base(message)
        {
        }
    }
}
