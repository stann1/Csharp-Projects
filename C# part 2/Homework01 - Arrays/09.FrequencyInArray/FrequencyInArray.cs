using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.FrequencyInArray
{
    class FrequencyInArray
    {
        static void Main(string[] args)
        {
            int[] array = {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3};
            int counter = 1;
            int bestCount = 1;

            Array.Sort(array);
            int bestNumber = array[0];

            if (array.Length > 1)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] == array[i - 1])
                    {
                        counter++;
                    }
                    else
                    {
                        if (counter > bestCount)
                        {
                            bestCount = counter;
                            bestNumber = array[i - 1];
                        }

                        counter = 1;
                    }
                }
            }
            
            Console.WriteLine("The number {0} appears most frequently --> {1} times", bestNumber, bestCount);
        }
    }
}
