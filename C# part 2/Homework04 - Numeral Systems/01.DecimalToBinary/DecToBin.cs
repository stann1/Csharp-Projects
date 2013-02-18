using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.DecimalToBinary
{
    class DecToBin
    {
        static void Main(string[] args)
        {
            int number = 14;
            List<int> result = new List<int>();

            while (number > 0)
            {
                result.Add(number % 2);
                number /= 2;
            }

            Console.WriteLine("The number in binary:");
            for (int i = result.Count - 1; i >= 0 ; i--)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
    }
}
