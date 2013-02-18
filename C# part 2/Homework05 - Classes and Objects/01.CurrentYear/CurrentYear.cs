using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.CurrentYear
{
    class CurrentYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("The year is leap?: " + DateTime.IsLeapYear(year));
           
        }
    }
}
