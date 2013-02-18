using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.FibonacciSum
{
    class FibonacciSum
    {
        static void Main(string[] args)
        {
            BigInteger first = 0;
            BigInteger second = 1;
            BigInteger total = 0;
            Console.WriteLine("Enter a number to calculate Fibonacci series sum");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                total += first;
                BigInteger sum = first + second;
                first = second;
                second = sum;
            }
            Console.WriteLine("The sum of the first {0} members is: {1}", n, total);
        }   
    }
}
