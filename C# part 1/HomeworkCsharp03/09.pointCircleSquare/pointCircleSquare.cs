using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.pointCircleSquare
{
    class pointCircleSquare
    {
        static void Main(string[] args)
        {
            float xPoint = 4f;   // should be sbyte if we use only integer numbers
            float yPoint = 2f;

            bool insideCircle = ((xPoint - 1) * (xPoint - 1) + (yPoint - 1) * (yPoint - 1)) <= (3 * 3);
            bool insideSquare = ((xPoint >= -1) && (xPoint <= 5)) && ((yPoint >= -1) && (yPoint <= 1));

            Console.WriteLine("The point is:" + " " + (insideCircle ? "inside the circle" : "outside the circle"));
            Console.WriteLine("and" + " " + (insideSquare ? "inside the square" : "outside the square"));


        }
    }
}
