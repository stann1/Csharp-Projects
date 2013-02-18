using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.TrailingZeroes
{
    class TrailingZeroes
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a (positive) number N:");
            int n = int.Parse(Console.ReadLine());
            int divisor = 5;
            int zeroCounter = 0;

            do
            {
                zeroCounter += n / divisor;
                divisor *= 5;

            } while (divisor <= n);

            Console.WriteLine("The factorial of {0} has {1} trailing zeroes", n, zeroCounter);
        }
    }
}
