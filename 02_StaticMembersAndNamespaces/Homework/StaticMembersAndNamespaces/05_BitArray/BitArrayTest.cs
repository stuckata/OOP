using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BitArray
{
    class BitArrayTest
    {
        static void Main(string[] args)
        {
            BitArray bits = new BitArray();

            bits[0] = 1;
            bits[5] = 1;
            bits[5] = 0;
            bits[25] = 1;
            bits[31] = 1;

            Console.WriteLine("The decimal representation of this number is: " + bits);
        }
    }
}
