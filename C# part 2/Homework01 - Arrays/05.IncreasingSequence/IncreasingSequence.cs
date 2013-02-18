using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.IncreasingSequence
{
    class IncreasingSequence
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 2, 1, 3, 5, 7, 7, 9, 10, 13};
            int maxCounter = 0;
            int start = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int counter = 1;
                while (i < array.Length - 1 && array[i] < array[i+1])
                {
                    counter++;
                    i++;
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    start = i - maxCounter + 1;
                }
            }
            Console.WriteLine("The maximal increasing seuqence is {0}", maxCounter);
            for (int i = start; i < start + maxCounter; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
