using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;

namespace _19.ExtractDates
{
    class ExtractDates
    {
        static void Main(string[] args)
        {
            string text = "Some random date 17.08.2012, followed by another date - 19.02.2013";
            string pattern = @"\d{2}\.\d{2}\.\d{4}";

            MatchCollection dates = Regex.Matches(text, pattern);

            foreach (var date in dates)
            {
                string transform = date.ToString();
                DateTime newDate = DateTime.Parse(transform);
                Console.WriteLine(newDate.ToString("dd.MM.yyyy", CultureInfo.GetCultureInfo("en-CA")));
            }
        }
    }
}
