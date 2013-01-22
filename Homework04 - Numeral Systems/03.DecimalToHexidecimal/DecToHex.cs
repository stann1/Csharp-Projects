using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.DecimalToHexidecimal
{
    class DecToHex
    {
        static void Main(string[] args)
        {
            int number = 28;
            List<int> result = new List<int>();

            while (number > 0)
            {
                result.Add(number % 16);
                number /= 16;
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
    }
}
