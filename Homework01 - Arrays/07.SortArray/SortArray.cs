using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.SortArray
{
    class SortArray
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 5, -2, 3, -7, 11, 1, 9 };

            for (int element = 0; element < array.Length - 1; element++)   //go through each element (without the very last)
            {
                for (int i = element+1; i < array.Length; i++)              //swap current element with the next smallest number
                {
                    if (array[element] > array[i])
                    {
                        int tempNumber = array[element];
                        array[element] = array[i];
                        array[i] = tempNumber;
                    }
                }
            }

            Console.WriteLine("The sorted array is:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
                
            }
            Console.WriteLine();
        }
    }
}
