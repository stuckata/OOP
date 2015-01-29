using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SquareRoot
{
    public class SquareRoot
    {
        private string number;

        public SquareRoot(string number)
        {
            this.Number = number;
        }

        public string Number
        {
            get
            {
                return this.number;
            }
            set
            {
                try
                {
                    Int32.Parse(value);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Inavlid integer number!");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Null is not a number!");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Not a number! You have to enter an integer number!");
                }             
                catch (OverflowException)
                {
                    Console.WriteLine("This number is too big to fit in Int32!");
                }
                finally
                {
                    this.number = value;
                }
            }
        }

        public static double CalculateSquareRoot(string num)
        {
            double result = 0;
            result = Math.Sqrt(Int32.Parse(num));
            try
            {
                Int32.Parse(result + "");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid integer number! You have to enter positive number!");
            }
            return result;
        }

        public override string ToString()
        {
            return String.Format("SquareRoot({0}) = {1}", this.Number, CalculateSquareRoot(this.Number));
        }
    }
}
