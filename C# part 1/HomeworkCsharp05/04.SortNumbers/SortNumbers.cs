using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            double a = 16;
            double b = 3;
            double c = 14.1;

            if (a >= b)
            {
                if (a >= c)
                {
                    if (b >= c)
                    {
                        Console.WriteLine("The numbers - largest to smallest are {0} / {1} / {2}", a, b, c);
                    }
                    else
                    {
                        Console.WriteLine("The numbers - largest to smallest are {0} / {1} / {2}", a, c, b);
                    }
                }
                else
                {
                    Console.WriteLine("The numbers - largest to smallest are {0} / {1} / {2}", c, a, b);
                }
            }
            else              // a < b
            {
                if (b >= c)
                {
                    if (c >= a)
                    {
                        Console.WriteLine("The numbers - largest to smallest are {0} / {1} / {2}", b, c, a);
                    }
                    else
                    {
                        Console.WriteLine("The numbers - largest to smallest are {0} / {1} / {2}", b, a, c);
                    }
                }
                else     // a < b and b < c
                {
                    Console.WriteLine("The numbers - largest to smallest are {0} / {1} / {2}", c, b, a);
                }
            }
        }
    }
}
