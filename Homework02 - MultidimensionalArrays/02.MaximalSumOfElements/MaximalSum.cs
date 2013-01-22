using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.MaximalSumOfElements
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            //=================================================================
            //int n = 4;                 //Use for testing  
            //int m = 5;

            //int[,] matrix = {
            //                { 0, 2, 4, 0, 9 },
            //                { 7, 1, 3, 3, 2 },
            //                { 1, 3, 9, 8, 5 },
            //                { 4, 6, 7, 9, 1 }
            //                };
            //=================================================================

            Console.WriteLine("Enter number of rows:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns:");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("number[{0},{1}] = ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //=================================================================

            int bestSum = int.MinValue;
            int bestStartRow = 0;
            int bestStartColumn = 0;

            for (int row = 0; row <= n-3; row++)
            {
                for (int col = 0; col <= m-3; col++)
                {
                    int tempSum = 0;                           
                    tempSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                            + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                            + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    //Can also be done with another pair of nested loops, but since we have a fixed size, it is not needed

                    if (tempSum > bestSum)
                    {
                        bestSum = tempSum;
                        bestStartRow = row;
                        bestStartColumn = col;
                    }
                }
            }

            Console.WriteLine("Best sum: {0}, coordinates of start point: ({1}, {2})", bestSum, bestStartRow, bestStartColumn);
            for (int i = bestStartRow; i < bestStartRow + 3; i++)
            {
                for (int j = bestStartColumn; j < bestStartColumn + 3; j++)
                {
                    Console.Write("{0,-5}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
