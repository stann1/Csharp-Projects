using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CartesianCoordinates
{
    class CartesianCoordinates
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());
            int output = 0;

            if (x == 0)
            {
                if (y > 0 || y < 0)
                {
                    output = 5;
                }
            }
            else if (x > 0)
            {
                if (y == 0)
                {
                    output = 6;
                }
                else if (y > 0)
                {
                    output = 1;
                }
                else if (y < 0)
                {
                    output = 4;
                }
            }
            else if (x < 0)
            {
                if (y == 0)
                {
                    output = 6;
                }
                else if (y > 0)
                {
                    output = 2;
                }
                else if (y < 0)
                {
                    output = 3;
                }
            }
            Console.WriteLine(output);
        }
    }
}
