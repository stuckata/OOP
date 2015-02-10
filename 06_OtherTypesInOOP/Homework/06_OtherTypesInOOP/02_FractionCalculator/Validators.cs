using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FractionCalculator
{
    public static class Validators
    {
        public static void AssertIntgerNumberIsInRange(string value, string porpertyName)
        {
            long resultValue = 0;

            try
            {
                resultValue = long.Parse(value);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(porpertyName + " could not be null!");
                throw e;
            }
            catch (FormatException e)
            {
                Console.WriteLine(porpertyName + " is not an Integer!");
                throw e;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(porpertyName + " is not in range [-9223372036854775808…9223372036854775807]!");
                throw e;
            }
        }

        public static void AssertDenominatorIsNotZero(long value)
        {
            if (value == 0)
            {
                throw new ArgumentException("Denominator could not be 0!");
            }
        }
    }
}
