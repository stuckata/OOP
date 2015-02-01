using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CompanyHierarchy.Models
{
    public static class Validators
    {
        public static void AssertNotEmpty(string value, string propName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(propName, propName + " cannot be empty");
            }
        }

        public static void AssertStringSize(string value, int minSize, string propName)
        {
            if (value.Length < minSize)
            {
                throw new ArgumentException(propName + " should be at least " + minSize + " characters");
            }
        }

        public static void AssertMinValue(dynamic value, int minValue, string propName)			
            //dynamic is used so value is valid for decimal and double
        {
            if (value <= minValue)
            {
                throw new ArgumentOutOfRangeException(propName + " cannot be less or equal to " + minValue);
            }
        }
    }
}

