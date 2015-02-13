using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_StringBuilderExtensionMethods;

namespace _01_StringBuilderExtensionsTest
{
    public class StringBuilderExtensionsTest
    {
        static void Main(string[] args)
        {
            string test = "The quick brown fox jumps over the lazy dog.";
            string separator = "=============================================================================";
            StringBuilder testText = new StringBuilder();
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("The test text -> " + test);
            Console.WriteLine(separator);
            testText.Append(test);

            Console.WriteLine("Substring test -> " + testText.Substring(0, 9));
            Console.WriteLine(separator);
            Console.WriteLine("Remove test -> " + testText.RemoveText("FOX"));
            Console.WriteLine(separator);
            Console.WriteLine("AppendAll test with list of numbers [1...10]-> " + testText.AppendAll(numbers));
            Console.WriteLine(separator);
            Console.WriteLine();
        }
    }
}
