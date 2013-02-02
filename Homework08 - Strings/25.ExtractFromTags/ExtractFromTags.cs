using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace _25.ExtractFromTags
{
    class ExtractFromTags
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\input.html");

            using (reader)
            {
                //string input = "<head>Some<title>News</title></head>" +              //used for testing
                //            "<body><a href=>body-text</a><p></p></body>";
                string input = reader.ReadToEnd();

                string patternBody = @"(?<=>)[^<>]*(?=<)";
                MatchCollection body = Regex.Matches(input, patternBody);

                Console.WriteLine("Extracted text:");
                foreach (var item in body)
                {
                    string line = item.ToString();

                    if (line != "\r\n" && line != "")
                    {
                        Console.WriteLine(line);
                    }

                }
            }
            
           
        }
    }
}
