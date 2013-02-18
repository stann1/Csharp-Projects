using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintNumbers1N
{
    class PrintNumbers1N
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
