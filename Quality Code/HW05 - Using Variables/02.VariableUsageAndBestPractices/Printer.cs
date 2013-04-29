using System;
using System.Linq;

namespace _02.VariableUsageAndBestPractices
{
    class Printer
    {
        public void PrintStatistics(double[] data, int count)
        {
            double maxValue = double.MinValue;            
            for (int i = 0; i < count; i++)
            {
                if (data[i] > maxValue)
                {
                    maxValue = data[i];
                }
            }
            Print(maxValue);

            double minValue = maxValue;
            for (int i = 0; i < count; i++)
            {
                if (data[i] < minValue)
                {
                    minValue = data[i];
                }
            }
            Print(minValue);

            double sumOfAllValues = 0;
            for (int i = 0; i < count; i++)
            {
                sumOfAllValues += data[i];
            }
            Print(sumOfAllValues / count);
        }

        private void Print(double result)
        {
            Console.WriteLine(result);           
        }       

    }
}
