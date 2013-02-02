using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _18.ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string emails = "Beginning ala@abv.bg, some other text bewteeen, yalala@yahoo.com.";

            string pattern = @"\w+@\w+\.\w+";

            MatchCollection match = Regex.Matches(emails, pattern);

            Console.WriteLine("Extracted emails:");
            foreach (var item in match)
            {
                Console.WriteLine(item);
            }
        }
    }
}
