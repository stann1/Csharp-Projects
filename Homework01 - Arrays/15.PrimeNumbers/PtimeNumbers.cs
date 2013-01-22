using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15.PrimeNumbers
{
    class PtimeNumbers
    {
        static void Main(string[] args)
        {
            DateTime begin = DateTime.Now;
            int max = 10000000;
            bool[] array = new bool[max];

            for (int div = 2; div <= Math.Sqrt(max); div++)
            {
                if (array[div] == true)          //No operations will be done with numbers that are already tagged as non-prime
                {
                    continue;
                }
                
                for (int element = 2*div; element < max; element += div)
                {
                    array[element] = true;         //Each element which is a function of a prime number is tagged
                }
               
            }

            for (int i = 2; i < max; i++)
            {
                if (array[i] == false)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Elapsed time:");
            DateTime end = DateTime.Now;
            Console.WriteLine(end - begin);
        }
    }
}
