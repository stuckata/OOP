using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            int start = 1;
            int end = 100;

            PrintTextFields.PrintInputConditions();
            PrintTextFields.EnterNumbers();
            Processes.ReadNumbers(start, end);
        }
    }
}
