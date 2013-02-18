using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.modifyBit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            int givenN = 89; //given number
            int modifyV = 0; //value for modification 0 or 1
            int positionP = 4; // position to modify

            int mask = 1;

            Console.WriteLine("The given number is: {0}", givenN);

            if (modifyV == 1)
            {
                mask = mask << positionP;
                Console.Write("The modification with bit {0} at position {1} returns:", modifyV, positionP);
                Console.WriteLine(givenN | mask);
            }
            else
            {
                mask = ~(mask << positionP);
                Console.Write("The modification with bit {0} at position {1} returns:", modifyV, positionP);
                Console.WriteLine(givenN & mask);
            }

        }
    }
}
