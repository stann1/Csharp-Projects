using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DivisionByFive
{
    class DivByFive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            uint firstNum = uint.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            uint secondNum = uint.Parse(Console.ReadLine());
            uint resultCount = 0;

            if (secondNum >= firstNum)      // check if number is positive
            {
                for (uint i = firstNum; i <= secondNum; i++)
                {
                    if (i % 5 == 0)
                    {
                        resultCount = resultCount + 1;
                    }
                }
            }
            else
            {
                for (uint i = secondNum; i <= firstNum; i++)
                {
                    if (i % 5 == 0)
                    {
                        resultCount = resultCount + 1;
                    }
                }
            }

            Console.WriteLine("The numbers that can be divided by 5 are {0}:", resultCount);
        }
    }
}
