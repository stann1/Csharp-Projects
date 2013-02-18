using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BonusScores
{
    class BonusScores
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a digit (1-9)");
            string input = Console.ReadLine();
            byte inputDigit;
            int result = 0;
            bool isDigit = byte.TryParse(input, out inputDigit);

            if (isDigit)
            {
                switch (inputDigit)
                {
                    case 1:
                    case 2:
                    case 3: result = inputDigit * 10;
                        Console.WriteLine("The new result is:" + " " + result);
                        break;
                    case 4:
                    case 5:
                    case 6: result = inputDigit * 100;
                        Console.WriteLine("The new result is:" + " " + result);
                        break;
                    case 7:
                    case 8:
                    case 9: result = inputDigit * 1000;
                        Console.WriteLine("The new result is:" + " " + result);
                        break;
                    default: Console.WriteLine("Not a valid digit - must be in the range (1-9)");
                        break;
                }
            }
            else
            {
                Console.WriteLine("The input is not a valid digit. Please try again.");
            }

        }
    }
}
