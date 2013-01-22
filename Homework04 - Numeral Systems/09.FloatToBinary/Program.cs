using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.FloatToBinary
{
    class Program
    {
        static void ConvertToBinary(int number)
        {
            List<int> result = new List<int>();
            bool signed = number < 0;

            if (signed)
            {
                number = 128 + number;        //short min value is -32768
            }

            while (number > 0)
            {
                result.Add(number % 2);
                number /= 2;
            }

            if (signed)
            {
                while (result.Count < 7)          //Will add 0 for unlocated bits.
                {
                    result.Add(0);
                }
                result.Add(1);
            }

            for (int i = result.Count - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
                       

            
        }
    }
}
