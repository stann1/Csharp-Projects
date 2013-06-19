using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountValues
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<double, int> dict = new Dictionary<double, int>();
            double[] numbers = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            foreach (var num in numbers)
            {
                int count = 1;
                if (dict.ContainsKey(num))
                {
                    count = dict[num] + 1;
                }
                dict[num] = count;
            }

            foreach (var pair in dict)
            {
                Console.WriteLine("{0} --> {1} time(s)", pair.Key, pair.Value);
            }
        }
    }
}
