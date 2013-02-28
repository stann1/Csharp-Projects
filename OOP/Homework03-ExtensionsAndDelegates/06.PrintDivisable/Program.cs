using System;
using System.Linq;

namespace _06.PrintDivisable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 6, 7, 12, 21, 28, 4, 11, 42 };

            //using Lambda expressions
            var selected = array.Where(x => (x % 3 == 0 && x % 7 == 0));

            Console.WriteLine("(Lambda)The numbers that are divisable by 3 and 7:");
            foreach (var item in selected)
            {
                Console.WriteLine(item);
            }

            //using LINQ
            var selectionQuery =
                from number in array
                where number % 3 == 0 && number % 7 == 0
                select number;

            Console.WriteLine("(LINQ)The numbers that are divisable by 3 and 7:");
            foreach (var item in selectionQuery)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
