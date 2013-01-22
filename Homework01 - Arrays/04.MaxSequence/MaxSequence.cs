using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.MaxSequence
{
    class MaxSequence
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 2, 1, 5, 7, 7, 7, 9, 3, 2 };
            int maxCounter = 0;
            int start = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int counter = 1;
                while (i < array.Length - 1 && array[i] == array[i + 1])    //for each element checks the next ones that are equal
                {
                    counter++;
                    i++;                           //this makes sure that after the outside loop will continue from the last equal number(avoiding repetition)
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    start = i - maxCounter + 1;
                }
            }
            Console.WriteLine("The maximal seuqence is {0}", maxCounter);
            for (int i = start; i < start + maxCounter; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
    }
}
