using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _09.CatalanNumber
{
    class CatalanNumber
    {
        static void Main(string[] args)
        {
            int n = 16;
            BigInteger numerator = 1;
            BigInteger denominator = 1;

            for (int i = 2*n; i > n; i--)
            {
                numerator *= i;
            }

            for (int j = n + 1; j > 1; j--)
            {
                denominator *= j;
            }

            Console.WriteLine("The nth Catalan number is: {0}", numerator/denominator);
        }
    }
}
