using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EnterNumbers
{
    class Processes
    {
        public static void ReadNumbers(int start, int end)
        {
            int previousNum = 0;
            int tempNum = 0;

            for (int i = 1; i <= 10; i++)
            {
                previousNum = tempNum;
                PrintTextFields.PrintNumberOfEnteredValue(i);
                string input = Console.ReadLine();

                while (!isValidNum(input, previousNum))
                {
                    PrintTextFields.PrintNumberOfEnteredValue(i);
                    input = Console.ReadLine();
                }
                tempNum = int.Parse(input);
            }
        }

        public static bool isValidNum(string input, int previousNum)
        {
            bool isInt = true;
            bool inRange = true;
            bool isBigger = true;

            try
            {
                int num = 0;
                isInt = int.TryParse(input, out num);
                if (!isInt)
                {
                    throw new FormatException();
                }
                else
                {
                    inRange = 1 < num && num < 100;
                    isBigger = num > previousNum;
                    if (!inRange)
                    {
                        throw new NotInDefinedRangeException("The number is not in a given range!");
                    }
                    else if (!isBigger)
                    {
                        throw new NotBiggerThanPreviousNumberException("The number should be bigger than previos number!");
                    }
                }
            }
            catch (FormatException)
            {
                PrintTextFields.PrintInvalidNumber();
                PrintTextFields.PrintFormatException();
            }
            catch (NotInDefinedRangeException)
            {
                PrintTextFields.PrintInvalidNumber();
                PrintTextFields.PrintNotInRangeException();
            }
            catch (NotBiggerThanPreviousNumberException)
            {
                PrintTextFields.PrintInvalidNumber();
                PrintTextFields.PrintNotBiggerThanPrevios();
            }
            return (isInt && inRange && isBigger);
        }
    }
}
