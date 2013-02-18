using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrintSum
{
    class PrintSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int firstNum = int.Parse(Console.ReadLine());
            int additionalNum = 0;
            int sum = 0;

            if (firstNum > 0)
            {
                for (int i = 0; i < firstNum; i++)
                {
                    Console.WriteLine("Enter next number");
                    additionalNum = int.Parse(Console.ReadLine());
                    sum = sum + additionalNum;
                }

                Console.WriteLine("The sum of the numbers is {0}:", sum);
            }
            else
            {
                Console.WriteLine("The number you enter must be > 0!");
            }
        }
    }
}
