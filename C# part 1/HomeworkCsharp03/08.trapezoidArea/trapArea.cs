using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.trapezoidArea
{
    class trapArea
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = 8;
            double h = 3;
            double area = (a+b)*h/2;    
            
            Console.WriteLine("The area of the trapezoid is {0}", area);


        }
    }
}
