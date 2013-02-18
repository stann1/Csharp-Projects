using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.PrintSpiral
{
    class PrintSpiral
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (0 < n < 20) for the matrix:");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int count = 0;
            int rowStart = 0;
            int colStart = 0;
            int maxRow = n - 1;
            int maxCol = n - 1;

            if (n <= 0 || n >= 20)
            {
                Console.WriteLine("Wrong input, please try again!");
            }
            else
            {
                while (count < n * n)
                {
                    //numbering from left to right
                    for (int i = colStart; i <= maxCol; i++)
                    {
                        count++;
                        matrix[rowStart, i] = count;
                    }
                    rowStart++;

                    //top to bottom    
                    for (int i = rowStart; i <= maxRow; i++)
                    {
                        count++;
                        matrix[i, maxCol] = count;
                    }
                    maxCol--;

                    //right to left
                    for (int i = maxCol; i >= colStart; i--)
                    {
                        count++;
                        matrix[maxRow, i] = count;
                    }
                    maxRow--;

                    //bottom to top
                    for (int i = maxRow; i >= rowStart; i--)
                    {
                        count++;
                        matrix[i, colStart] = count;
                    }
                    colStart++;
                }

                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        Console.Write("{0, 4}", matrix[rows, cols]);
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
