using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PerformanceOfPrimitiveTypes
{
    static class MultiplicationProcedure
    {
        internal static TimeSpan MultiplyInt(int startValue, int endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int result = 0;
            for (int i = 0; i < endIndex; i++)
            {
                result = 26 * startValue;
            }
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }

        internal static TimeSpan MultiplyFloat(float startValue, float endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            float result = 0f;
            for (int i = 0; i < endIndex; i++)
            {
                result = 26.1f * startValue;
            }
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }

        internal static TimeSpan MultiplyLong(long startValue, long endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long result = 0L;
            for (int i = 0; i < endIndex; i++)
            {
                result = 26L * startValue;
            }
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }

        internal static TimeSpan MultiplyDouble(double startValue, double endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            double result = 0d;
            for (int i = 0; i < endIndex; i++)
            {
                result = 26.1d * startValue;
            }
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }

        internal static TimeSpan MultiplyDecimal(decimal startValue, decimal endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            decimal result = 0m;
            for (int i = 0; i < endIndex; i++)
            {
                result = 26.1m * startValue;
            }
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }
    }
}
