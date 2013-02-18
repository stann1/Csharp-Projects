using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.checkThirdBit
{
    class checkBit3
    {
        static void Main(string[] args)
        {
            int a = 9; // 1001
            int mask = 1;
            mask = mask << 3;

            int result = (a&mask)>>3;
            Console.WriteLine("The 3d bit is {0}", result);
        }
    }
}
