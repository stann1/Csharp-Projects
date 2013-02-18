using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a size for the arrays");
            int size = int.Parse(Console.ReadLine());
            int[] arrayA = new int[size];
            int[] arrayB = new int[size];
           
            Console.WriteLine("Fill in {0} numbers for array A:", size);
            for (int i = 0; i < size; i++)
            {
                arrayA[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Fill in {0} numbers for array B:", size);
            for (int i = 0; i < size; i++)
            {
                arrayB[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The indexes with equal numbers are (starting from 0) are:");
            for (int i = 0; i < size; i++)
            {
                if (arrayA[i] == arrayB[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
