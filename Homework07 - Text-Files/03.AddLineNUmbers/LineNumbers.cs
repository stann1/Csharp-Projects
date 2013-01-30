using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.AddLineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("sample2.txt");
            StreamWriter writer = new StreamWriter("output.txt");

            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();
                    int lineNum = 1;
                    while (line != null)
                    {
                        writer.WriteLine(lineNum + " " + line);
                        lineNum++;
                        line = reader.ReadLine();
                    }
                }
            }

        }
    }
}
