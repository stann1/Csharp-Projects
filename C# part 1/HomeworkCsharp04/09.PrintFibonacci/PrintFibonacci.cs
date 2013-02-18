using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics; 

namespace _09.PrintFibonacci
{
    class PrintFibonacci
    {
        static void Main(string[] args)
        {
            BigInteger first = -1;
            BigInteger second = 1;
            Console.WriteLine("The first 100 terms of the Fibonacci series are:");
            for (int i = 0; i < 100; i++)
            {
                BigInteger sum = first + second;
                first = second;
                second = sum;
                Console.WriteLine(second);
            }
        }
    }
}
