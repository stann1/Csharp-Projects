using System;
using System.Linq;

namespace _02.VariableUsageAndBestPractices
{
    class VariableUsage
    {
        static void Main(string[] args)
        {
            Printer statPrinter = new Printer();
            double[] dataBase = new double[] { -3, 1, 6, 29, 14 };
            int count = dataBase.Length;
            statPrinter.PrintStatistics(dataBase, count);
        }        

    }
}
