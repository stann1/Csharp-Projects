using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            int side1;
            int side2;
            int side3;
            int angle;
            int height;

            //Standart area formula, when height is known
            side1 = 6;
            height = 5;
            double triangleArea = side1 * height / 2.0;                
            Console.WriteLine("Area of triangle 1: " + triangleArea);

            //Heron's formula for 3 sides known
            side1 = 4;
            side2 = 7;
            side3 = 7;

            double s = (side1 + side2 + side3) / 2.0;
            triangleArea = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            Console.WriteLine("Area of triangle 2: " + triangleArea);

            //Using trigonometry for 2 sides and an angle between (S = a*b*sin(angle) / 2)
            side1 = 6;
            side2 = 8;
            angle = 65;

            triangleArea = side1 * side2 * Math.Sin(angle) / 2.0;
            Console.WriteLine("Area of triangle 3: " + triangleArea);
        }
    }
}
