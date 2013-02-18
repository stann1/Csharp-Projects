using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ReadMatrix
{
    class ReadMatrix
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\matrix.txt");

            using (reader)
            {
                int n = int.Parse(reader.ReadLine());
                string nextLine = reader.ReadLine();
                nextLine = nextLine.Replace(" ", "");        //Removes empty spaces

                int matrixSize = nextLine.Length;
                int[,] matrix = new int[matrixSize, matrixSize];        //The matrix should be square (rows = cols)
                int row = 0;

                while (nextLine != null)
                {
                    nextLine = nextLine.Replace(" ", "");

                    for (int col = 0; col < matrixSize; col++)
                    {
                        matrix[row, col] = nextLine[col] - 48;       //read each number and save it in the matrix                     

                    }
                    nextLine = reader.ReadLine();

                    row++;
                }

                int bestsum = int.MinValue;
                for (int i = 0; i < matrixSize - 1; i++)
                {
                    for (int j = 0; j < matrixSize - 1; j++)
                    {
                        int tempSum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];

                        if (tempSum > bestsum)
                        {
                            bestsum = tempSum;
                        }
                    }

                }
                Console.WriteLine("The best sum of 2x2 sized sub-matrix is: {0}", bestsum);
            }
        }
    }
}
