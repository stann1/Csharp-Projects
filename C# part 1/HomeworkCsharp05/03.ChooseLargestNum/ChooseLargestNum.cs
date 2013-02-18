using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ChooseLargestNum
{
    class ChooseLargestNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 3 numbers - a, b, c");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a >= c)
                {
                    Console.WriteLine("The largest number is \"a\"");
                }
                else if (c >= b)
                {
                    Console.WriteLine("The largest number is \"c\"");
                }
            }
            else if (a <= b)
            {
                if (b >= c)
                {
                    Console.WriteLine("The largest number is \"b\"");
                }
                else if (c >= a)
                {
                    Console.WriteLine("The largest number is \"c\"");
                }
            }
        }
    }
}
