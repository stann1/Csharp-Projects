﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Variations
{
    class Variations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value for K:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a value for N:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[k];

            GetVariations(array, 0, n);            //Input given consists of: array(with defined size), starting index 0 and the max number
            
        }

        private static void GetVariations(int[] array, int k, int n)
        {
            if (k == array.Length)          //Recursion bottom - when k reaches max the result is printed
            {
                PrintResult(array);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    array[k] = i;
                    GetVariations(array, k + 1, n);     //The recursive element increases the index k with 1 on each call
                }
            }
        }

        private static void PrintResult(int[] array)
        {
            foreach (var number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        

        
        
    }
}
