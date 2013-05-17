using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PerformanceOfMathOperations
{
    class TestPerformance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square root (in order - float, double, decimal):");
            Console.WriteLine(SquareRootProcedure.SqrtFloat(16.4f, 100000f));
            Console.WriteLine(SquareRootProcedure.SqrtDouble(16.4d, 100000d));
            Console.WriteLine(SquareRootProcedure.SqrtDecimal(16.4m, 100000m));
            Console.WriteLine();

            Console.WriteLine("Logarithm (in order - float, double, decimal):");
            Console.WriteLine(LogarithmProcedure.LogFloat(16.4f, 100000f));
            Console.WriteLine(LogarithmProcedure.LogDouble(16.4d, 100000d));
            Console.WriteLine(LogarithmProcedure.LogDecimal(16.4m, 100000m));
            Console.WriteLine();

            Console.WriteLine("Sinus (in order - float, double, decimal):");
            Console.WriteLine(SinusProcedure.SinFloat(16.4f, 100000f));
            Console.WriteLine(SinusProcedure.SinDouble(16.4d, 100000d));
            Console.WriteLine(SinusProcedure.SinDecimal(16.4m, 100000m));
            Console.WriteLine();
        }
    }
}
