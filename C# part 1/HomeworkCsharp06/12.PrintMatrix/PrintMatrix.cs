using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.PrintMatrix
{
    class PrintMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size N (< 20) for the matrix:");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0 || n >= 20)
            {
                Console.WriteLine("Wrong input!");
            }
            else
            {
                for (int row = 0; row < n; row++)
                {
                    for (int column = 1; column <= n; column++)
                    {
                        Console.Write(row + column);
                    }
                    Console.WriteLine();
                }
            } 
        }
    }
}
