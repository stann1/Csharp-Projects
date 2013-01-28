using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SortStrings
{
    class SortStrings
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\listNames.txt");
            StreamWriter writer = new StreamWriter(@"..\..\listSorted.txt");

            using (reader)
            {
                using (writer)
                {
                    List<string> stringList = new List<string>();
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        stringList.Add(line);
                        line = reader.ReadLine();
                    }

                    stringList.Sort();

                    foreach (var lines in stringList)
                    {
                        writer.WriteLine(lines);
                    }
                }
            }
        }
    }
}
