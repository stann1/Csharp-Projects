using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PerformanceOfMathOperations
{
    class LogarithmProcedure
    {
        internal static TimeSpan LogFloat(float startValue, float endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < endIndex; i++)
            {
                Math.Log(startValue);
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        internal static TimeSpan LogDouble(double startValue, double endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < endIndex; i++)
            {
                Math.Log(startValue);
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        internal static TimeSpan LogDecimal(decimal startValue, decimal endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < endIndex; i++)
            {
                Math.Log((double)startValue);
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }
    }
}
