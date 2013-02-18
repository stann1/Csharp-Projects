using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.checkPrime
{
    class checkPrime
    {
        static void Main(string[] args)
        {
            int myNumber = 17;
            bool primeNumber = true;

            for (int i = 2; i < myNumber; i++)
            {
                if (myNumber % i == 0)
                {
                    primeNumber = false;
                }
                
            }

            Console.WriteLine("Is the number {0} prime? : {1}", myNumber, primeNumber);
          
        }
    }
}
