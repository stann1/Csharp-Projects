using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MathExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            int mod = (int)(m % 180);

            double result = (n * n + 1 / (m * p) + 1337) / (n - 128.523123123 * p) + Math.Sin(mod);
            Console.WriteLine("{0:0.000000}", result);
        }
    }
}
