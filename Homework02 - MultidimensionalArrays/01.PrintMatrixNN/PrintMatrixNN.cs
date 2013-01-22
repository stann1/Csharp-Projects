using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.PrintMatrixNN
{
    class PrintMatrixNN
    {
        static void PrintMatrix(int size, int[,] matrix)      //Method for printing the matrix
        {
            for (int i = 0; i < size; i++)             
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0,-4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void GenerateMatrixA(int n, int[,] matrix)
        {
            for (int column = 0, counter = 1; column < n; column++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, column] = counter++;
                }
            }

            PrintMatrix(n, matrix);
        }

        static void GenerateMatrixB(int n, int[,] matrix)
        {
            for (int column = 0, counter = 1, direction = 1; column < n; column++, direction++)
            {
                if (direction % 2 != 0)             //Direction DOWN, when odd number
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, column] = counter++;
                    }
                }
                else                                //Direction UP, when even number
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrix[row, column] = counter++;
                    }
                }

            }

            PrintMatrix(n, matrix);
        }


        static void GenerateMatrixC(int n, int[,] matrix)
        {
            int counter = 1;
            for (int row = n - 1; row >= 0; row--)                 //Works from bottom-left to diagonal
            {
                for (int col = 0; col < n - row; col++)
                {
                    matrix[row + col, col] = counter++;
                }

            }

            for (int col = 1; col < n; col++)                     //Mirror operation
            {
                for (int row = 0; row < n - col; row++)
                {
                    matrix[row, row + col] = counter++;
                }
            }

            PrintMatrix(n, matrix);
                      

        }


        static void GenerateMatrixD(int n, int[,] matrix)
        {
            int startRow = 0;
            int startCol = 0;
            int maxRow = n - 1;
            int maxCol = n - 1;
            int counter = 1;

            while (counter <= n * n)
            {
                //direction Down:
                for (int row = startRow; row <= maxRow; row++)
                {
                    matrix[row, startCol] = counter++;
                }
                startCol++;

                //direction Rigth:
                for (int column = startCol; column <= maxCol; column++)
                {
                    matrix[maxRow, column] = counter++;
                }
                maxRow--;

                //direction Up:
                for (int row = maxRow; row >= startRow; row--)
                {
                    matrix[row, maxCol] = counter++;
                }
                maxCol--;

                //direction Left:
                for (int column = maxCol; column >= startCol; column--)
                {
                    matrix[startRow, column] = counter++;
                }
                startRow++;
            }


            PrintMatrix(n, matrix);
        }


        static void Main(string[] args)
        {
            int n = 10;
            int[,] matrix = new int[n, n];

            GenerateMatrixA(n, matrix);
            GenerateMatrixB(n, matrix);
            GenerateMatrixC(n, matrix);
            GenerateMatrixD(n, matrix);

            
        }
        
    }
}
