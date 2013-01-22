using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.BaseConversion
{
    class Program
    {
        static int ConvertBaseXto10(string inputNumber, int inputBase)
        {
            int decNum = 0;

            for (int i = 0; i < inputNumber.Length; i++)
            {
                int digit = inputNumber[i] - '0';        //the digit for A is 17, thus we must substract 7
                if (digit > 9)
                {
                    digit -= (17 - 10);
                }

                decNum += digit * (int)Math.Pow(inputBase, (inputNumber.Length - 1 - i));
            }

            return decNum;
        }

        static void ConvertBase10toY(int inputNumber, int outputBase)
        {
            List<int> result = new List<int>();

            while (inputNumber > 0)
            {
                result.Add(inputNumber % outputBase);
                inputNumber /= outputBase;
            }

            for (int i = result.Count - 1; i >= 0; i--)
            {
                if (result[i] > 9)
                {
                    Console.WriteLine((char)(result[i] + 55));
                }
                else
                {
                    Console.Write(result[i]);
                }
            }
            Console.WriteLine();
        }

        static void ConvertBaseXtoBaseY(string inputNumber, int inputBase, int outputBase)
        {
            int numberInDecimal = ConvertBaseXto10(inputNumber, inputBase);
            ConvertBase10toY(numberInDecimal, outputBase); 
        }


        static void Main(string[] args)
        {
            string inputNumber = "1001101011";         //Can be used for testing
            int inputBase = 2;
            int outputBase = 16;

            ConvertBaseXtoBaseY(inputNumber, inputBase, outputBase);
        }

        

        
        
    }
}
