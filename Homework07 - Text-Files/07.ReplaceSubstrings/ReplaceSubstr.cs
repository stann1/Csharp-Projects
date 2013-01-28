using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReplaceSubstrings
{
    class ReplaceSubstr
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
                        line = line.Replace("start", "finish");
                        writer.WriteLine(line);

                        line = reader.ReadLine();
                    }

                }
            }
        }
    }
}
