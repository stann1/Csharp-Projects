using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            int a = 5598;
            int b = 1302;
            int remainder = 1;

            while (remainder != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }
            Console.WriteLine(a);

        }
    }
}
