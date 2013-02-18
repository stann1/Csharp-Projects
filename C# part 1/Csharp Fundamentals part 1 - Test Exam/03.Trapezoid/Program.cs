using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < 2*n; j++)
                {
                    if (j + i == n && i != 0)
                    {
                        Console.Write("*");             // first row
                    }
                    else if (i == 0 && j >= n)
                    {
                        Console.Write("*");   
                    }
                    else if (i == n)                    //last row
                    {
                         Console.Write("*");
                    }
                    else if (j == 2 *n-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
