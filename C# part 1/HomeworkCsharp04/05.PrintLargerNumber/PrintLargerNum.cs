using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PrintLargerNumber
{
    class PrintLargerNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            int b = int.Parse(Console.ReadLine());

            int maxAB = Math.Max(a, b);
            Console.WriteLine("The larger number is:" + " " + maxAB);
        }
    }
}
