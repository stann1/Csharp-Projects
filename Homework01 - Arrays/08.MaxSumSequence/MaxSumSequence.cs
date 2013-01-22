using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.MaxSumSequence
{
    class MaxSumSequence
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int bestSum = array[0];
            int tempSum = array[0];
            int tempStart = 0;
            int bestStart = 0;
            int bestEnd = 0;


            for (int i = 1; i < array.Length; i++)      //Go over each element
            {
                tempSum += array[i];
               
                if (array[i] > tempSum)                 //Check if the next element is larger than the sum so far
                {
                    tempSum = array[i];
                    tempStart = i;
                }

                if (tempSum > bestSum)                  //Find the last element for which the sum is larger than the next sum
                {
                    bestSum = tempSum;
                    bestStart = tempStart;
                    bestEnd = i;
                }



            }
            Console.WriteLine("The maximal sum of consequtive numbers is: {0}", bestSum);
            for (int i = bestStart; i <= bestEnd; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
