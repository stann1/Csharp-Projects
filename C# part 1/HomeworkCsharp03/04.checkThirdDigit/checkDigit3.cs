using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.checkThirdDigit
{
    class checkDigit3
    {
        static void Main(string[] args)
        {
            int number = 568632;
            Console.WriteLine(number);
            
            int converted = number % 1000;
            
            if (converted / 100 == 7)
            {
                Console.WriteLine("The 3d digit (right to left) is 7");
            }
            else
            {
                Console.WriteLine("The 3d digit (right to left) is different from 7!");
            }
        }
    }
}
