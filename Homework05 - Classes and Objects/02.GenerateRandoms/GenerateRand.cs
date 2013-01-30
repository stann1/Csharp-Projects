using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.GenerateRandoms
{
    class GenerateRand
    {
        static void Main(string[] args)
        {
            Random randGenerator = new Random();

            Console.WriteLine("Randoms (100 - 200):");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(randGenerator.Next(100, 201));
            }
        }
    }
}
