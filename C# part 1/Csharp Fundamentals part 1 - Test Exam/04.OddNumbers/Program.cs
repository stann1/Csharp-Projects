using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] inputs = new long[n];

            for (int i = 0; i < n; i++)
            {
                inputs[i] = long.Parse(Console.ReadLine());
            }

            Array.Sort(inputs);

            for (int i = 1; i <= n; i += 2)
            {
                if (i >= n - 1)
                {
                    Console.WriteLine(inputs[n-1]);
                    break;
                }
                else if (i < n-1)
                {
                    if (inputs[i] != inputs[i -1])
                    {
                        Console.WriteLine(inputs[i - 1]);
                        break;
                    }
                }
                
            }
        }
    }
}
