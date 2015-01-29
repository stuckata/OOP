using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EnterNumbers
{
    class PrintTextFields
    {
        public static void PrintInputConditions()
        {
            Console.WriteLine("You have to enter 10 numbers in a range [1, 2, ... 100] which fulfill the following conditions:");
            Console.WriteLine("1 < a1 < … < a10 < 100");
        }

        public static void EnterNumbers()
        {
            Console.WriteLine("Enter numbers:");
        }

        public static void PrintInvalidNumber()
        {
            Console.WriteLine("Invalid number!");
        }

        public static void PrintFormatException()
        {
            Console.WriteLine("This is not an integer!");
        }

        public static void PrintNotInRangeException()
        {
            Console.WriteLine("The number is not in a given range!");
        }

        public static void PrintNotBiggerThanPrevios()
        {
            Console.WriteLine("The number should be bigger than previos number!");
        }

        public static void PrintNumberOfEnteredValue(int number)
        {
            Console.Write("{0}. ", number);
        }
    }
}
