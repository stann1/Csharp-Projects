using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CustomException
{
    class Program
    {
        static void Main(string[] args)
            //testing number ranges
        {   int start = 1;
            int end = 100;
            Console.WriteLine("Enter a number in the range 1-100:");
            int number = int.Parse(Console.ReadLine());

            if (number < start || number > end)
            {
                throw new InvalidRangeException<int>(start, end, "Number is out of range");
            }
            else
            {
                Console.WriteLine("Success");
            }

            //testing date ranges
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);

            Console.WriteLine("Enter a date between {0} and {1}, in the format dd/m/yyyy", startDate, endDate);
            DateTime inputDate = DateTime.Parse(Console.ReadLine());
            if (inputDate < startDate || inputDate > endDate)
            {
                throw new InvalidRangeException<DateTime>(startDate, endDate, "The date is out of the required range");
            }
            else
            {
                Console.WriteLine("Success");
            }
        }
    }
}
