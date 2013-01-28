using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.CompareLines
{
    class CompareLines
    {
        static void Main(string[] args)
        {
            StreamReader firstReader = new StreamReader(@"..\..\file1.txt");
            StreamReader secondReader = new StreamReader(@"..\..\file2.txt");

            using (firstReader)
            {
                using (secondReader)
                {
                    string firstLine = firstReader.ReadLine();
                    string secondLine = secondReader.ReadLine();
                    int lineNum = 1;

                    Console.WriteLine("Lines that are equal:");
                    while (firstLine != null && secondLine != null)
                    {
                        if (firstLine == secondLine)
                        {
                            Console.Write(lineNum + " ");
                        }

                        lineNum++;
                        firstLine = firstReader.ReadLine();
                        secondLine = secondReader.ReadLine();
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
