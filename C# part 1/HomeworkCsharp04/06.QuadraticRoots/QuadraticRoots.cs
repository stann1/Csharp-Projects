using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticRoots
{
    class QuadraticRoots
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a-coefficient:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter b-coefficient:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter c-coefficient:");
            int c = int.Parse(Console.ReadLine());

            double xFirst = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            double xSecond = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

            Console.WriteLine((b * b - 4 * a * c) >= 0 ? "The roots of the equation" + " " +
            "are {0:f2}, {1:f2}." : "There are no real roots", xFirst, xSecond);
        }
    }
}
