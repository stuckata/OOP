using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BitArray
{
    class BitArray
    {
        public const int BITS_COUNT = 100000;
        private uint bitValues;
        private List<int> positionsOfBitsWithValueOne = new List<int>();

        // Indexer declaration
        public int this[int index]
        {
            get
            {
                if ((index >= 0) && (index < BITS_COUNT))
                {
                    // Check the bit at position index
                    if ((bitValues & (1 << index)) == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }                
                }
                else
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Index {0} is invalid!", index));
                }
            }

            set
            {
                if ((index < 0) || (index > BITS_COUNT - 1))
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Index {0} is invalid!", index));
                }
                if ((value < 0) || (value > 1))
                {
                    throw new ArgumentException(String.Format(
                        "Value {0} is invalid!", value));
                }

                // Clear the bit at position index
                bitValues &= ~((uint)(1 << index));

                // Set the bit at position index to value
                bitValues |= (uint)(value << index);
                if (value != 0)
                {
                    this.positionsOfBitsWithValueOne.Add(index);
                }    
            }
        }

        public static long ConvertBinaryToDecimalNumber(List<int> positionsOfBitsWithValueOne)
        {
            long result = 0;

            for (int i = 0; i < positionsOfBitsWithValueOne.Count(); i++)
            {
                result += (long)Math.Pow(2, positionsOfBitsWithValueOne[i]);
            }
            return result;
        }

        public override string ToString()
        {
            return ConvertBinaryToDecimalNumber(this.positionsOfBitsWithValueOne).ToString();
        }
    }
}
