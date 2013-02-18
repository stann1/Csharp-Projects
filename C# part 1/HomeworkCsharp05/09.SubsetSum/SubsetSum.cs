using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SubsetSum
{
    class SubsetSum
    {
        static void Main(string[] args)
        {
            int a = -14;                         // Works properly, but sometimes repetition occurs (when there are equal variables)
            int b = 6;
            int c = -2;
            int d = -4;
            int e = 6;
            int[] array = new int[] { a, b, c, d, e };
            bool noSet = true;


            if (a + b + c + d + e == 0)
            {
                Console.WriteLine("The whole selection sums to 0");
                noSet = false;
            }
            for (int i = 0; i < 5; i++)
            {
                int tempsum = array[i];
                for (int j = 0; j < 5 && j != i; j++)
                {
                    int tempsum1 = tempsum + array[j];
                    if (tempsum1 == 0)
                    {
                        Console.WriteLine("The subsets that sum to 0 are: ({0}, {1})", array[i], array[j]);
                        noSet = false;
                    }
                    for (int k = 0; k < 5 && (k != j) && (k != i); k++)
                    {
                        int tempsum2 = tempsum1 + array[k];
                        if (tempsum2 == 0)
                        {
                            Console.WriteLine("The subsets that sum to 0 are: ({0}, {1}, {2})", array[i], array[j], array[k]);
                            noSet = false;
                        }
                        for (int l = 0; l < 5 && (l != k) && (l != j) && (l != i); l++)
                        {
                            int tempsum3 = tempsum2 + array[l];
                            if (tempsum3 == 0)
                            {
                                Console.WriteLine("The subsets that sum to 0 are: ({0}, {1}, {2}, {3})", array[i],
                                    array[j], array[k], array[l]);
                                noSet = false;
                            }

                        }
                    }
                }
            }
            if (noSet)
            {
                Console.WriteLine("No subsets sum to 0");
            }
        }
    }
}
