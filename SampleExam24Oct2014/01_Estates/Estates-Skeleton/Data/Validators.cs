using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    public static class Validators
    {
        public static void AssertValueIsInRange(dynamic value, int minValue, int maxValue, string propName)
        {
            if (value <= minValue)
            {
                throw new ArgumentOutOfRangeException(propName + " cannot be less or equal to " + minValue + "!");
            }

            if (value > maxValue)
            {
                throw new ArgumentOutOfRangeException(propName + " cannot be bigger than " + maxValue + "!");
            }
        }
    }
}
