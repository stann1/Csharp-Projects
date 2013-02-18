using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.PrintTextToConsole
{
    class PrintText
    {
        static void Main(string[] args)
        {
            int lineNumber = 1;
            string path = @"..\..\Program.cs";

            using (StreamReader inputReader = new StreamReader(path))
            {
                string line = inputReader.ReadLine();
                while (line != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    lineNumber++;
                    line = inputReader.ReadLine();
                }
                
            }
        }
    }
}
