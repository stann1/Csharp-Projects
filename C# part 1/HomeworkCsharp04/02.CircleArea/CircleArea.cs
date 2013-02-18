using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CircleArea
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius for the circle");
            double rad = double.Parse(Console.ReadLine());

            Console.WriteLine("The perimeter of the circle is {0:f2}, the area is {1}.", (2 * Math.PI * rad), (rad * rad));
        }
    }
}
