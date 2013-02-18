using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MaxElementPortion
{
    class MaxElement
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 2, 1, 2, 7, 6, 13, 4 };

            int position = 3;
            int bestPos = GetMaxFromPosition(array, position);
            Console.WriteLine("Starting from position {0}, the largest number is: {1}", position, array[bestPos]);

            bool sortAscending = true;
            array = SortArray(array, sortAscending);

            Console.WriteLine("The sorted array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        private static int[] SortArray(int[] array, bool isAscending)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int bestPos = GetMaxFromPosition(array, i);
                int temp = array[i];
                array[i] = array[bestPos];
                array[bestPos] = temp;

            }
            if (isAscending)
            {
                array = array.Reverse().ToArray();
            }

            return array;
        }


        private static int GetMaxFromPosition(int[] array, int position)
        {
            int bestPosition = 0;
            int bestNumber = int.MinValue;   
            for (int i = position; i < array.Length; i++)
            {
                if (array[i] > bestNumber)
                {
                    bestNumber = array[i];
                    bestPosition = i;
                }
            }

            return bestPosition;
        }
    }
}
