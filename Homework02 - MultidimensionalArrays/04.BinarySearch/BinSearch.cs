using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.BinarySearch
{
    class BinSearch
    {
        static void Main(string[] args)
        {
            //int[] array = { 3, 8, 12, 2, 6, 5 };          //Use this for testing purposes
            //int k = 16;
            //int n = array.Length;

            Console.WriteLine("Please enter size N for the array and number to search:");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];


            Console.WriteLine("Enter numbers for the array:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            int index = Array.BinarySearch(array, k);
            Console.WriteLine(index);
            if (index >= 0)
            {
                Console.WriteLine("The largest number that is <= {0} is {1}", k, k);
            }
            else if (index < 0)
            {
                if (~index >= array.Length)         //This means all numbers are smaller than K, so we take the last
                {
                    Console.WriteLine("The largest number that is <= {0} is {1}", k, array[n - 1]);
                }
                else if (~index == 0)                
                {
                    Console.WriteLine("No numbers are <= {0}", k);
                }
                else                         // ~index will show the next largest number, so we substract 1 from it
                {
                    Console.WriteLine("The largest number that is <= {0} is {1}", k, array[~index - 1]);
                }
            }

            

        }
    }
}
