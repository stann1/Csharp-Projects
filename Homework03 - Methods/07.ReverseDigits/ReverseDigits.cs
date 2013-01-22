using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseDigits
{
    class ReverseDigits
    {
        static void Main(string[] args)
        {
            int number = 256;

            int reversed = ReverseNumber(number);
            Console.WriteLine(reversed);
        }

        static int ReverseNumber(int number)
        {
            List<int> digitList = new List<int>();
            int reversed = 0;

            for (int i = number; i != 0; i /= 10)             //The check condition is !=0 (not > 0) in order to work for negatives numbers
            {
                digitList.Add(i % 10);
            }

            for (int i = digitList.Count - 1, multiplicator = 1; i >= 0; i--, multiplicator *= 10)
            {
                reversed += digitList[i] * multiplicator;
            }

            return reversed;

        }
    }
}
