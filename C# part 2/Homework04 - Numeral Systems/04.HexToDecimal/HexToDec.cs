using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.HexToDecimal
{
    class HexToDec
    {
        static void Main(string[] args)
        {
            string hex = "1B";
            
            double decNum = 0;

            for (int i = 0; i < hex.Length; i++)
            {
                int digit = hex[i] - '0';        //the digit for A is (strangely) 17, thus we substract 7
                if (digit > 9)
                {
                    digit -= 7;           
                }
                
                decNum += digit * Math.Pow(16, (hex.Length - 1 - i));
            }

            Console.WriteLine("The hex number {0} is: {1}", hex, decNum);
        }
    }
}
