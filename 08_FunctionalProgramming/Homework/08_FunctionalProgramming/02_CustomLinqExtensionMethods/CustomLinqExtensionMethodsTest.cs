using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CustomLinqExtensionMethods
{
    public class CustomLinqExtensionMethodsTest
    {
        static void Main(string[] args)
        {
            IList<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var oddNumbers = numbers.WhereNot(n => n % 2 == 0);

            Console.WriteLine("NUMBERS: ");
            Console.WriteLine("[ {0} ]", String.Join(", ", numbers));
            Console.WriteLine();
            Console.WriteLine("ODD NUMBERS: ");
            Console.WriteLine("[ {0} ]", String.Join(", ", oddNumbers));
            Console.WriteLine();

            var numbersToRepeat = numbers.Repeat(2);

            Console.WriteLine("REPEAT NUMBERS: ");
            Console.WriteLine("[ {0} ]", String.Join(", ", numbersToRepeat));
            Console.WriteLine();

            IList<string> words = new List<string>()
            {
                "cat",
                "dog",
                "robocat",
                "robodog",
                "caterpiller",
                "shepherddog",
                "turtle",
                "rabit",
                "crocodile"
            };
            IList<string> suffixes = new List<string>() { "cat", "dog"};
            var wordsWithSuffix = words.WhereEndsWith(suffixes);

            Console.WriteLine("WORDS: ");
            Console.WriteLine("[ {0} ]", String.Join(", ", words));
            Console.WriteLine();
            Console.WriteLine("WORDS WHICH END WITH SUFIXES 'cat' AND 'dog': ");
            Console.WriteLine("[ {0} ]", String.Join(", ", wordsWithSuffix));
            Console.WriteLine();
        }
    }
}
