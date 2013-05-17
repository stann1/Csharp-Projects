using System;
using System.Text;

namespace Matrix
{
    public class TraversableMatrix
    {
        public static int incrementValue = 1; 
        public static readonly int[] DirectionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        public static readonly int[] DirectionY = { 1, 0, -1, -1, -1, 0, 1, 1 };

        public static void FillMatrix(int[,] matrix, ref int row, ref int col)
        {
            int matrixDimensions = matrix.GetLength(0);
            int currentDirectionX = 1, currentDirectionY = 1;

            while (true)
            {
                matrix[row, col] = incrementValue;

                if (AdjacentCellsNotTraversable(matrix, row, col))
                {
                    break;
                }

                while (CurrentDirectionNotPossible(matrix, row, col, currentDirectionX, currentDirectionY))
                {
                    ChangeDirection(ref currentDirectionX, ref currentDirectionY);
                }

                row += currentDirectionX;
                col += currentDirectionY;
                incrementValue++;
            }
        }

        private static bool CurrentDirectionNotPossible(int[,] matrix, int row, int col, int currentDirectionX, int currentDirectionY)
        {
            int matrixDimensions = matrix.GetLength(0);
            if (row + currentDirectionX >= matrixDimensions || row + currentDirectionX < 0)
            {
                return true;
            }
            if (col + currentDirectionY >= matrixDimensions || col + currentDirectionY < 0)
            {
                return true;
            }
            if (matrix[row + currentDirectionX, col + currentDirectionY] != 0)
            {
                return true;
            }

            return false;
        }

        private static void ChangeDirection(ref int currentDirectionX, ref int currentDirectionY)
        {            
            int directionIndex = 0;
            for (int count = 0; count < DirectionX.Length; count++)
            {
                if (DirectionX[count] == currentDirectionX && DirectionY[count] == currentDirectionY)
                {
                    directionIndex = count;
                    break;
                }
            }

            if (directionIndex == 7)
            {
                currentDirectionX = DirectionX[0];
                currentDirectionY = DirectionY[0];
            }
            else
            {
                currentDirectionX = DirectionX[directionIndex + 1];
                currentDirectionY = DirectionY[directionIndex + 1];
            }
        }

        public static bool AdjacentCellsNotTraversable(int[,] matrix, int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0))
            {
                throw new ArgumentOutOfRangeException("row", "The row index is outside of the matrix");
            }
            if (col < 0 || col >= matrix.GetLength(1))
            {
                throw new ArgumentOutOfRangeException("column", "The column index is outside of the matrix");
            }

            int[] testDirectionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] testDirectionY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < testDirectionX.Length; i++)
            {
                if (row + testDirectionX[i] >= matrix.GetLength(0) || row + testDirectionX[i] < 0)
                    testDirectionX[i] = 0;

                if (col + testDirectionY[i] >= matrix.GetLength(0) || col + testDirectionY[i] < 0)
                    testDirectionY[i] = 0;
            }

            for (int i = 0; i < 8; i++)
            {
                if (matrix[row + testDirectionX[i], col + testDirectionY[i]] == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void FindFreeCell(int[,] matrix, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        x = i;
                        y = j;
                        return;
                    }
                }
            }
        }

        public static void PrintMatrix(int matrixDimensions, int[,] matrix)
        {           
            for (int row = 0; row < matrixDimensions; row++)
            {
                for (int col = 0; col < matrixDimensions; col++)
                {
                    Console.Write(matrix[row, col]);
                    if (col < matrix.GetLength(1) - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();                
            }
        }

        public static string OutputMatrixToString(int[,] matrix)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append(matrix[i, j]);
                    if (j < matrix.GetLength(1) - 1)
                    {
                        sb.Append(" ");
                    }
                }
                sb.Append("\r\n");
            }

            return sb.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a size n for the matrix (1 <= n <= 100):");
            string input = Console.ReadLine();

            int matrixDimensions = 0;
            bool validRange = int.TryParse(input, out matrixDimensions);

            if (!validRange)
            {
                throw new FormatException("The input was not in the correct Int32 format");
            }
            if (matrixDimensions < 1 || matrixDimensions > 100)
            {
                throw new ArgumentOutOfRangeException("size", "The provided size was not in the allowed ranged");
            }
            int[,] matrix = new int[matrixDimensions, matrixDimensions];

            int row = 0, col = 0;

            FillMatrix(matrix, ref row, ref col);
            
            if (matrixDimensions > 4)
            {
                FindFreeCell(matrix, out row, out col);
                incrementValue++;
                FillMatrix(matrix, ref row, ref col);
            }            

            PrintMatrix(matrixDimensions, matrix);           
        }
  
       
        
    }
}