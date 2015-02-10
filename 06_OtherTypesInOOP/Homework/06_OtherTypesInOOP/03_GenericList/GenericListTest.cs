using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GenericList
{
    public class GenericListTest
    {
        static void Main()
        {
            GenericList<int> testList = new GenericList<int>();
            testList.Add(2);
            testList.Add(7);
            testList.Add(19);
            testList.Add(14);
            testList.Add(9);
            Console.WriteLine(testList);
            Console.WriteLine(testList.Access(2));
            Console.WriteLine(testList.Find(19));
            Console.WriteLine(testList);
            testList.Insert(55, 2);
            Console.WriteLine(testList);
            Console.WriteLine(testList.Find(55));
            testList.Remove(2);
            Console.WriteLine(testList);
            testList.Clear();
            Console.WriteLine(testList);
        }
    }
}
