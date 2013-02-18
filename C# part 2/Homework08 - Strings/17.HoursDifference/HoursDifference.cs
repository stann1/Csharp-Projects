using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace _17.HoursDifference
{
    class HoursDifference
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a date:");
            //string input1 = Console.ReadLine();
            
            string input1 = "29.01.2013 12:21";         //used for testing
            
            DateTime now = DateTime.ParseExact(input1, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture);
            now = now.AddHours(6.5);

            Console.Write("After 6h and 30 min will be: ");
            Console.WriteLine(now);
            
            Console.WriteLine(now.ToString("dddd", CultureInfo.GetCultureInfo("BG-bg")));
        }
    }
}
