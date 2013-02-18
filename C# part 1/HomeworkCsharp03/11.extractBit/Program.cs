using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.extractBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 19;
            int b = 4;
            int mask = 1;

            mask = mask << b;
            int result = (i & mask) >> b;

            Console.WriteLine("The bit at position {0} is: {1}", b, result);
        }
    }
}
