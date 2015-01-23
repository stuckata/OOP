using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Validators
{
    public static void AssertNotEmpty(string value, string propName)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentNullException("The " + propName + " is required.");
        }
    }

    public static void AssertIsPositive(decimal value, string propName)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException("The " + propName + "must be positive.");
        }
    }
}

