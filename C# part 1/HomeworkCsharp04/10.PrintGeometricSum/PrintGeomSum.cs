using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PrintGeometricSum
{
    class PrintGeomSum
    {
        static void Main(string[] args)
        {
            double sum = 1;                                  //this is the sum of the series with only 1 term (1)


            for (int i = 2; 1.0 / i >= 0.001; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + 1.0 / i;
                }
                else
                {
                    sum = sum - 1.0 / i;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
