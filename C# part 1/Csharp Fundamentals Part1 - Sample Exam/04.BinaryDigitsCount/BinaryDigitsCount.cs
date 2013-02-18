using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BinaryDigitsCount
{
    class BinaryDigitsCount
    {
        static void Main(string[] args)
        {
            sbyte b = sbyte.Parse(Console.ReadLine());
            uint n = uint.Parse(Console.ReadLine());
            uint[] countList = new uint[n];
            bool firstBit = false;
            uint bitCount = 0;

            for (uint numbers = 0; numbers < n; numbers++)
            {
                uint nextNum = uint.Parse(Console.ReadLine());
                firstBit = false;
                bitCount = 0;
                for (int i = 31; i >= 0; i--)
                {
                    uint mask = 1;
                    mask = mask << i;
                    uint getBit = (nextNum & mask) >> i;
                    if (getBit == 1)
                    {
                        firstBit = true;
                    }
                    if (firstBit && (getBit == b))
                    {
                        bitCount++;
                    }
                }
                countList[numbers] = bitCount;
            }

            for (uint i = 0; i < countList.Length; i++)
            {
                Console.WriteLine(countList[i]);
            }
        }
    }
}
