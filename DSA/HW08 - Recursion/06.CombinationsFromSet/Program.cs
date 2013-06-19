﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CombinationsFromSet
{
    class Program
    {
        static string[] set = new string[] { "a", "b", "c", "d" };
        static int size;
        static string[] result;

        static void Main(string[] args)
        {
            Console.WriteLine("Set size: {0}. Enter subset size to generate combinations:", set.Length);
            size = int.Parse(Console.ReadLine());
            result = new string[size];

            GenerateVariations(0, 0);
        }

        private static void GenerateVariations(int index, int start)
        {
            if (index >= size)
            {
                Console.WriteLine(string.Join(", ", result));
                return;
            }

            for (int i = start; i < set.Length; i++)
            {
                result[index] = set[i];
                GenerateVariations(index + 1, i + 1);
            }
        }
    }
}
