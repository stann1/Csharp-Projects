using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.MaxSumArray
{
    class MaxSumArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a size N for the array:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number K < N");
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            int bestSum = 0;
            int tempSum = 0;
            int bestStart = 0;

            Console.WriteLine("Enter {0} numbers for the array:", n);
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= n - k; i++)
            {
                if (i == 0)
                {
                    for (int j = i; j < i + k; j++)     //Sums the first k numbers
                    {
                        tempSum += array[j];
                    }
                    bestSum = tempSum;
                }
                else                                    //next sum is formed from the difference of i+k and i
                {
                    tempSum += array[i + k - 1] - array[i - 1];
                }
                if (tempSum > bestSum)          
                {
                    bestStart = i;
                    bestSum = tempSum;     
                   
                }
                
            }
            Console.WriteLine("The maximal sum of {0} consequtive numbers is: {1}", k, bestSum);
            for (int i = bestStart; i < bestStart + k; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
