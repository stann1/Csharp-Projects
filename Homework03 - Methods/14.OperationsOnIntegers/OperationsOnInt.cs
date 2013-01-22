using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.OperationsOnIntegers
{
    class OperationsOnInt
    {
        static int GetMinimum(params int[] array)
        {
            int min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        static int GetMaximum(params int[] array)
        {
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        static double GetAverage(params int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return (double)sum / array.Length;
        }

        static int GetSum(params int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        static int GetProduct(params int[] array)
        {
            int prod = 1;
            for (int i = 0; i < array.Length; i++)
            {
                prod *= array[i];
            }

            return prod;
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 5, 8, -2, 6, -3 };    //Used for testing only, all methods can receive variable number of params

            int min = GetMinimum(array);
            Console.WriteLine("Minimal number: {0}", min);

            int max = GetMaximum(array);
            Console.WriteLine("Max number: {0}", max);

            double average = GetAverage(array);
            Console.WriteLine("Average: {0}", average);

            int sum = GetSum(array);
            Console.WriteLine("Sum: {0}", sum);

            int product = GetProduct(array);
            Console.WriteLine("Product: {0}", product);
        }
    }
}
