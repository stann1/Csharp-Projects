using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FractionSum
{
    class FractionSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two positive integers:");
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double sum = 1;
            double numerator = 1;
            double denominator = 1;

            if (x > 0 && n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    numerator *= i;
                    denominator = 1;
                    for (int j = 1; j <= i; j++)
                    {
                        denominator *= x;
                    }
                    sum += (numerator / denominator);
                }
                Console.WriteLine("The sum of N!/X^N is: {0}", sum);
            }
            else
            {
                Console.WriteLine("The input numbers do not match the condition");
            }
        }
            
    }
}
