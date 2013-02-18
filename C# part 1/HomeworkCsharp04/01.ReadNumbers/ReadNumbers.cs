using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReadNumbers
{
    class ReadNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("The numbers are: {0}, {1}, {2}", a, b, c);
        }
    }
}
