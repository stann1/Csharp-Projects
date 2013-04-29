using System;
using System.Linq;

namespace _01.RefacorClasses
{
    class ResultPrinter
    {
        public void PrintBoolResult(bool input)
        {
            string output = input.ToString();
            Console.WriteLine(output);
        }
    }
}
