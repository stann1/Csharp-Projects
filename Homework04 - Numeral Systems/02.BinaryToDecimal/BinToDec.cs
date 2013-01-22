using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BinaryToDecimal
{
    class BinToDec
    {
        static void Main(string[] args)
        {
            string binary = "10110";
            
            double decNum = 0;

            for (int i = 0; i < binary.Length ; i++)
            {
                int digit = binary[i] - '0';
                decNum += digit*Math.Pow(2, (binary.Length - 1 - i));
            }

            Console.WriteLine(decNum);
        }
    }
}
