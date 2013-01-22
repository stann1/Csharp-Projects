using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BiggerInteger
{
    class BiggerInt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 integers on seperate lines:");
            int n = 3;
            int[] array = new int[n];
            for (int i = 0; i < 3; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            GetLargestN(array, n);
        }

        private static void GetLargestN(int[] array, int n)
        {
            Array.Sort(array);

            Console.WriteLine("The 2 largest numbers are: {0} and {1}", array[n-1], array[n-2]);
        }
    }
}
