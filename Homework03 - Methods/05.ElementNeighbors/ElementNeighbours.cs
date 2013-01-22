using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ElementNeighbors
{
    class ElementNeighbours
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 4, 1, 6, 7 };
            int position = 2;
            bool largerThanBoth = false;

            largerThanBoth = FindLargerNeightbour(array, position);

            if (largerThanBoth)
            {
                Console.WriteLine("The number at position {0} is bigger than its neightbours", position);
            }
            else
            {
                Console.WriteLine("The number at position {0} is NOT bigger than its neightbours", position);
            }
            

        }

        static bool FindLargerNeightbour(int[] array, int position)
        {
            if (position > 1 && position < array.Length - 1)
            {
                if (array[position] > array[position - 1] && array[position] > array[position + 1])
	            {
                    return true;
	            }
            }
            return false;
           

        }
    }
}
