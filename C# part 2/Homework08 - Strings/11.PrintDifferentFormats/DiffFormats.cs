using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.PrintDifferentFormats
{
    class DiffFormats
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Dec: {0,15:D}", number);
            Console.WriteLine("Hex: {0,15:X}", number);
            Console.WriteLine("Per: {0,15:P}", number);
            Console.WriteLine("Per: {0,15:E}", number);
        }
    }
}
