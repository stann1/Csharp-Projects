using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrintNumberSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int firstNum = int.Parse(Console.ReadLine());

            if (firstNum > 0)
            {
                Console.WriteLine("The array of the numbers is:");
                for (int i = 1; i <= firstNum; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("The number you enter must be > 0!");
            }
        }
    }
}
