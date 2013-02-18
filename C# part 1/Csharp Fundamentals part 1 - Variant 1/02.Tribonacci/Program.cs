using System;
using System.Numerics;


namespace _02.Tribonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger t1 = BigInteger.Parse(Console.ReadLine());
            BigInteger t2 = BigInteger.Parse(Console.ReadLine());
            BigInteger t3 = BigInteger.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            BigInteger sum;

            for (int i = 0; i < n-3; i++)
            {
                sum = t1 + t2 + t3;
                t1 = t2;
                t2 = t3;
                t3 = sum;
            }
            Console.WriteLine(t3);
        }
    }
}
