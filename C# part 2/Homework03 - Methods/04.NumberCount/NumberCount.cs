using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumberCount
{
    class NumberCount
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 4, 1, 6, 1 };
            int number = 1;

            CountNumber(array, number);


        }

        static void CountNumber(int[] array, int number)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    counter++;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("The number is not in the array");
            }
            else
            {
                Console.WriteLine("The number {0} appears {1} times", number, counter);
            }
            
        }

    }
}
