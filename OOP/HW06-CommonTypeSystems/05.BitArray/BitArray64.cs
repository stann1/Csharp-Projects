using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitArray
{
    class BitArray64 : IEnumerable<int>
    {
        public ulong LongNumber { get; private set; }
        
        public BitArray64(ulong number)
        {
            this.LongNumber = number;
        }
               
        
        //Interface methods
        public BitArray64Enumerator GetEnumerator()
        {
             return new BitArray64Enumerator(this.ConverToBits());
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return (IEnumerator<int>)GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<int>)GetEnumerator();
        }

        //Bit converter
        private int[] ConverToBits()
        {
            ulong inputNumber = this.LongNumber;
            int[] bitArray = new int[64];

            for (int i = 63; i >= 0; i--)
            {
                if (inputNumber == 0)
                {
                    break;
                }
                bitArray[i] = (int)(inputNumber % 2);
                inputNumber /= 2;
            }

            return bitArray;
        }

        //Indexer
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    int[] bits = this.ConverToBits();
                    return bits[index];
                }
            }
        }

        //Overridden methods
        public override bool Equals(object obj)
        {
            BitArray64 tempArray = obj as BitArray64;
            if (tempArray == null)
            {
                return false;
            }
            else
            {
                if (ReferenceEquals(null, tempArray))
                {
                    return false;
                }
                if (ReferenceEquals(this, tempArray))
                {
                    return true;
                }
                return this.LongNumber == tempArray.LongNumber;
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return this.LongNumber.GetHashCode();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 63; i  >= 0; i--)
            {
                sb.Append(this[i]);
            }
            return sb.ToString();
        }

        //Overridden operators
        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !BitArray64.Equals(first, second);
        }

    }
}
