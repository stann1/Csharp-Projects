using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PerformanceOfMathOperations
{
    class SquareRootProcedure
    {
        internal static TimeSpan SqrtFloat(float startValue, float endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < endIndex; i++)
            {
                Math.Sqrt(startValue);
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        internal static TimeSpan SqrtDouble(double startValue, double endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < endIndex; i++)
            {
                Math.Sqrt(startValue);
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        internal static TimeSpan SqrtDecimal(decimal startValue, decimal endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < endIndex; i++)
            {
                Math.Sqrt((double)startValue);
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }
    }
}
