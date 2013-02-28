using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.IEnumerableExtensions
{ 
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sampleList = new List<int> { -1, 2, 4, 5, 19 };

            Console.WriteLine("Sum: {0}", sampleList.GetSum<int>());
            Console.WriteLine("Product: {0}", sampleList.GetProduct<int>());
            Console.WriteLine("Min element: {0}", sampleList.GetMin<int>());
            Console.WriteLine("Max element: {0}", sampleList.GetMax<int>());
            Console.WriteLine("Average: {0}", sampleList.GetAverage<int>());
        }
    }
}
