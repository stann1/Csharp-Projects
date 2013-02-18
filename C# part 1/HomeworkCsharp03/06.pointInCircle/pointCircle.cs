using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.pointInCircle
{
    class pointCircle
    {
        static void Main(string[] args)
        {
            byte xPoint = 3; //input 1
            byte yPoint = 4; //input 2
            byte xCircle = 0;
            byte yCircle = 0;
            byte r = 5;

            if (((xPoint - xCircle) * (xPoint - xCircle) + (yPoint - yCircle) * (yPoint - yCircle)) < (r * r))
            {
                Console.WriteLine("The point ({0},{1}) fits into the circle", xPoint, yPoint);
            }
            else
            {
                Console.WriteLine("The point ({0},{1}) does not fit", xPoint, yPoint);
            }

        }
    }
}
