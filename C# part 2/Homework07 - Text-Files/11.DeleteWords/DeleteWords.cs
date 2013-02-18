using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11.DeleteWords
{
    class DeleteWords
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\input-file.txt");
            StreamWriter writer = new StreamWriter(@"..\..\output.txt");

            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        line = Regex.Replace(line, @"\btest\w*\b", "");
                        line = Regex.Replace(line, @"\s{2,}", " ");
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
