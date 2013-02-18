using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.bitInInteger
{
    class bitPinV
    {
        static void Main(string[] args)
        {
            int v = 19;
            int p = 3;
            int mask = 1;
          
            mask = mask << p;
            bool result = ((v & mask) >> p) == 1;

            Console.WriteLine("The bit at position {0} is 1: {1}", p, result);
            
        }
    }
}
