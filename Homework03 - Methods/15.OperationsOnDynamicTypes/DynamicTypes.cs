using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.OperationsOnDynamicTypes
{
    class DynamicTypes
    {
        static T GetMinimum<T>(params T[] array)
        {
            dynamic min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        static T GetMaximum<T>(params T[] array)
        {
            dynamic max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        static T GetAverage<T>(params T[] array)
        {
            dynamic sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum / array.Length;
        }

        static T GetSum<T>(params T[] array)
        {
            dynamic sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        static T GetProduct<T>(params T[] array)
        {
            dynamic prod = 1;
            for (int i = 0; i < array.Length; i++)
            {
                prod *= array[i];
            }

            return prod;
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 5, 8, -2, 6, -3 };    //Used for testing only, all methods can receive variable number of params

            dynamic min = GetMinimum(-2m, -4.6m, 1.1m);
            Console.WriteLine("Minimal number: {0}", min);

            dynamic max = GetMaximum(-2, -4.6, 1.1);
            Console.WriteLine("Max number: {0}", max);

            dynamic average = GetAverage(-2, -4.6, 1.1);
            Console.WriteLine("Average: {0}", average);

            dynamic sum = GetSum(-2, -4.6, 1.1);
            Console.WriteLine("Sum: {0}", sum);

            dynamic product = GetProduct(-2, -4.6, 1.1);
            Console.WriteLine("Product: {0}", product);
        }
    }
}
