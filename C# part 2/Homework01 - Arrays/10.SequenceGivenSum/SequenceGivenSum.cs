using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.SequenceGivenSum
{
    class SequenceGivenSum
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 1, 4, 2, 5, -4};
            int s = 11;
            bool noSequence = true;

            int bestStart = 0;
            int bestEnd = 0;

            
            for (int i = 0; i < array.Length; i++)         //Access each consequtive element
            {
                int tempSum = 0;
                for (int j = i; j < array.Length; j++)    //For each element in i, it sums the rest elements of the array
                {
                    tempSum += array[j];
                    if (tempSum == s)                  //If a sum = S is found, then it prints the sequence
                    {
                        bestStart = i;
                        bestEnd = j;
                        noSequence = false;
                        Console.WriteLine("A sequence that sums to {0} is:", s);
                        for (int result = bestStart; result <= bestEnd; result++)
                        {
                            Console.Write(array[result] + " ");
                        }
                        Console.WriteLine();
                    }
                    
                }
               
            }

            if (noSequence)
            {
                Console.WriteLine("No sequence sums to {0}!", s);
            }
            
        }
    }
}
