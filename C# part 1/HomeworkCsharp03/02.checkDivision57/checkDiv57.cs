using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.checkDivision57
{
    class checkDiv57
    {
        static void Main(string[] args)
        {
            ushort number = 35;
            if ((number % 5 == 0) && (number % 7 == 0))
            {
                Console.WriteLine("The integer {0} can be divided by 5 and 7", number);
            }
            else
            {
                Console.WriteLine("The integer {0} cannot be divided by 5 and 7 at the same time", number);
            }
        }
    }
}
