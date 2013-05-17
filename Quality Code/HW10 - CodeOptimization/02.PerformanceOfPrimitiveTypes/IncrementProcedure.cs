﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PerformanceOfPrimitiveTypes
{
    static class IncrementProcedure
    {
        internal static TimeSpan IncrementInt(int startValue, int endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int result = 0;
            for (int i = 0; i < endIndex; i++)
            {
                result += startValue;
            }
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }

        internal static TimeSpan IncrementFloat(float startValue, float endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            float result = 0f;
            for (int i = 0; i < endIndex; i++)
            {
                result += startValue;
            }
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }

        internal static TimeSpan IncrementLong(long startValue, long endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long result = 0L;
            for (int i = 0; i < endIndex; i++)
            {
                result += startValue;
            }
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }

        internal static TimeSpan IncrementDouble(double startValue, double endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            double result = 0d;
            for (int i = 0; i < endIndex; i++)
            {
                result += startValue;
            }
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }

        internal static TimeSpan IncrementDecimal(decimal startValue, decimal endIndex)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            decimal result = 0m;
            for (int i = 0; i < endIndex; i++)
            {
                result += startValue;
            }
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }
    }
}
