using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediaShop.Items
{
    static class Validators
    {
        static void AssertStringIsValid(string value, int minLength, string propertyName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The {0} should not be null or empty string!", propertyName);
            }
            if (value.Length < minLength)
            {
                throw new ArgumentException(propertyName + " should be minimum " + minLength + " characters!");
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
