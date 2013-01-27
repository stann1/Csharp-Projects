using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.NameLastDigit
{
    class LastDigit
    {
        static void Main(string[] args)
        {
            int num = 514;
            string numString = num.ToString();

            Console.WriteLine("The last digit is:");
            GetLastDigit(numString);
        }

        static void GetLastDigit(string number)
        {
            char lastDigit = number[number.Length - 1];

            switch (lastDigit)
            {
                case '0': Console.WriteLine("Zero");
                    break;
                case '1': Console.WriteLine("One");
                    break;
                case '2': Console.WriteLine("Two");
                    break;
                case '3': Console.WriteLine("Three");
                    break;
                case '4': Console.WriteLine("Four");
                    break;
                case '5': Console.WriteLine("Five");
                    break;
                case '6': Console.WriteLine("Six");
                    break;
                case '7': Console.WriteLine("Seven");
                    break;
                case '8': Console.WriteLine("Eight");
                    break;
                case '9': Console.WriteLine("Nine");
                    break;
                default:
                    break;
            }
        }
    }
}
