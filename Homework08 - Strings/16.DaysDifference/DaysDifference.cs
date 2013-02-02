using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace _16.DaysDifference
{
    class DaysDifference
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two dates:");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            //string input1 = "29.01.2013";         //used for testing
            //string input2 = "02.02.2013";

            DateTime now = DateTime.ParseExact(input1, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime then = DateTime.ParseExact(input2, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Console.Write("Difference in days: ");
            Console.WriteLine((then-now).TotalDays);
        }
    }
}
