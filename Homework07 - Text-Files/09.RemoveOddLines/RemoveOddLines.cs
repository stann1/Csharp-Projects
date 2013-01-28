using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RemoveOddLines
{
    class RemoveOddLines
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
                    int lineNum = 1;
                    while (line != null)
                    {
                        if (lineNum % 2 == 0)
                        {
                            writer.WriteLine(line);
                        }

                        line = reader.ReadLine();
                        lineNum++;
                    }

                }
            }
            File.Replace(@"..\..\output.txt", @"..\..\input-file.txt", @"..\..\backup.txt");
        }
    }
}
