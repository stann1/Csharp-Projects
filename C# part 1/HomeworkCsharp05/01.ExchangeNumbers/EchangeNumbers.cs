using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExchangeNumbers
{
    class EchangeNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = 17;
            int secondNum = 8;

            if (firstNum > secondNum)
            {
                int temp = firstNum;
                firstNum = secondNum;
                secondNum = temp;
                Console.WriteLine("The first number becomes {0}, the second number becomes {1}", firstNum, secondNum);
            }
            else
            {
                Console.WriteLine("The second number is larger than the first");
            }
       }
    }
}
