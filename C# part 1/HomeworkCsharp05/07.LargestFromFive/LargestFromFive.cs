using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LargestFromFive
{
    class LargestFromFive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter five numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            int largestNum = a;

            if (largestNum < b)
            {
                largestNum = b;
            }
            if (largestNum < c)
            {
                largestNum = c;
            }
            if (largestNum < d)
            {
                largestNum = d;
            }
            if (largestNum < e)
            {
                largestNum = e;
            }
            Console.WriteLine("The largest number is: {0}", largestNum);
        }
    }
}
