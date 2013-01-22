using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FirstLargerNeighbor
{
    class LargestNeighbor
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 4, 1, 6, 7 };
            int position = 0;

            for (int i = 0; i < array.Length; i++)
            {
                position = FindLargerNeightbour(array, i);
                if (position >= 0)
                {
                    break;
                }
            }

            Console.WriteLine("Position of first number larger than its neighbors: {0}", position);


        }

        static int FindLargerNeightbour(int[] array, int position)
        {
            if (position > 1 && position < array.Length - 1)
            {
                if (array[position] > array[position - 1] && array[position] > array[position + 1])
                {
                    return position;
                }
            }
            return -1;


        }
    }
}
