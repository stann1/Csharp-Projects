using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.IEnumerableExtensions
{
    public static class IEnumerableExtensions
    {
        public static double GetSum<T>(this IEnumerable<T> collection)
        {
            double sum = 0;
            foreach (T item in collection)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static double GetProduct<T>(this IEnumerable<T> collection)
        {
            double prod = 1;
            foreach (T item in collection)
            {
                prod *= (dynamic)item;
            }

            return prod;
        }

        public static double GetMin<T>(this IEnumerable<T> collection)
        {
            double min = double.MaxValue;
            foreach (T item in collection)
            {
                if ((dynamic)item < min)
                {
                    min = (dynamic)item;
                }
            }

            return min;
        }

        public static double GetMax<T>(this IEnumerable<T> collection)
        {
            double max = double.MinValue;
            foreach (T item in collection)
            {
                if ((dynamic)item > max)
                {
                    max = (dynamic)item;
                }
            }

            return max;
        }

        public static double GetAverage<T>(this IEnumerable<T> collection)
        {
            double sum = 0;
            int counter = 0;
            foreach (T item in collection)
            {
                sum += (dynamic)item;
                counter++;
            }

            return sum/(double)counter;            
        }

    }
}
