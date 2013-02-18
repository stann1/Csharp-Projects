using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrintNotDivisible
{
    class PrintNotDiv
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 21 != 0)
                {
                    Console.WriteLine(i);
                 
                }
                
               
            }
        }
    }
}
