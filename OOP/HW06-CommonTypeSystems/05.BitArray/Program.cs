using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray64 firstNum = new BitArray64(146);
            foreach (var bit in firstNum)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            BitArray64 secondNum = new BitArray64(6749);
            foreach (var bit in secondNum)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            Console.WriteLine(firstNum.Equals(secondNum));

                        
        }
    }
}
