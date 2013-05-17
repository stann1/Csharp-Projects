using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PerformanceOfMathOperations
{
    class SinusProcedure
    {
        internal static TimeSpan SinFloat(float startValue, float endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < endIndex; i++)
            {
                Math.Sin(startValue);
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        internal static TimeSpan SinDouble(double startValue, double endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < endIndex; i++)
            {
                Math.Sin(startValue);
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        internal static TimeSpan SinDecimal(decimal startValue, decimal endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < endIndex; i++)
            {
                Math.Sin((double)startValue);
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }
    }
}
