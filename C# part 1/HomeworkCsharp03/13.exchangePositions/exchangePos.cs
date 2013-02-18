using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.exchangePositions
{
    class exchangePos
    {
        static void Main(string[] args)
        {

            int givenX = 2006584;
            Console.WriteLine("given integer is: {0}", Convert.ToString(givenX, 2).PadLeft(32, '0'));
            int mask = 7;        // in binary 0111

            int getFirstThree = (mask << 3) & givenX;       //extracts bits from positions 3,4,5
            getFirstThree = getFirstThree << 21;            // shifts them to position 24,25,26
            int getLastThree = (mask << 24) & givenX;       //extracts from 24,25,26
            getLastThree = getLastThree >> 21;              //shifts to 3,4,5

            givenX = givenX & (~(mask << 3));               //bits at 3,4,5 become 0
            int modifiedResult = givenX | getLastThree;     
            Console.WriteLine("Intermediate result:" + Convert.ToString(modifiedResult, 2).PadLeft(32, '0'));

            givenX = givenX & (~(mask << 21));               //bits at 24,25,26 become 0
            modifiedResult = givenX | getFirstThree;
            Console.WriteLine("Final Result:" + Convert.ToString(modifiedResult, 2).PadLeft(32, '0'));  //final result


 
         }
    }
}
   
            