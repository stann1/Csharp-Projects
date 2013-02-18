using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.ReplaceWholeWords
{
    class ReplaceWords
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
                        line = Regex.Replace(line, @"\bstart\b", "finish");
                        writer.WriteLine(line);

                        line = reader.ReadLine();
                    }

                }
            }
        }
    }
}
