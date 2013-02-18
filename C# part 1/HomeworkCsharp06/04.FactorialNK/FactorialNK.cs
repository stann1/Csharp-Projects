using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FactorialNK
{
    class FactorialNK
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 possitive numbers k, n (1 < k < n)");
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int product = 1;

            if (k > 1 && n >= 0 && k < n)
            {
                for (int i = n; i > k; i--)
                {
                    product *= i; 
                }
                Console.WriteLine("N!/K! = {0}", product);
            }
            else
            {
                Console.WriteLine("The input numbers do not meet the condition");
            }
        }
    }
}
