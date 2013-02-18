using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FactorialNKMultiple
{
    class FactorialMultiple
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 possitive numbers n, k (1 < n < k)");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int productN = 1;
            int productK = 1;

            if (n > 1 && k > 1 && n < k)
            {
                for (int i = n; i > 1; i--)
                {
                    productN *= i;
                }

                for (int j = k; j > k-n; j--)
                {
                    productK *= j;
                }
                Console.WriteLine("The product of N!*K!/(K-N) is {0}", productN*productK);
            }
            else
            {
                Console.WriteLine("The input numbers do not match the condition");
            }
        }
    }
}
