using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.LongestSequence
{
    class LongestSequence
    {
        static void Main(string[] args)
        {
            string[,] matrix = {                                    //Used for testing purposes
                            { "ha", "fifi", "ho", "hi" }, 
                            { "fo", "ha", "hi", "xx" }, 
                            { "xxx", "ho", "ha", "xx" }
                            };

            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int maxLength = 1;
            string mostFrequent = matrix[0, 0];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    int tempRow = row;
                    int tempCol = col;
                    int counter = 1;
                    //=========================================== checking rows
                    while (tempRow < n-1)
                    {
                        if (matrix[tempRow + 1, col] == matrix[tempRow, col])
                        {
                            counter++;
                        }
                        else
                        {
                            counter = 1;
                            break;
                        }

                        if (counter > maxLength)
                        {
                            maxLength = counter;
                            mostFrequent = matrix[tempRow, col];
                        }
                        tempRow++;
                    }

                    tempRow = row;
                    tempCol = col;
                    counter = 1;

                    //=========================================== checking columns
                    while (tempCol < m - 1)
                    {
                        if (matrix[row, tempCol + 1] == matrix[row, tempCol])
                        {
                            counter++;
                        }
                        else
                        {
                            counter = 1;
                            break;
                        }

                        if (counter > maxLength)
                        {
                            maxLength = counter;
                            mostFrequent = matrix[row, tempCol];
                        }
                        tempCol++;
                    }

                    tempRow = row;
                    tempCol = col;
                    counter = 1;

                    //=========================================== checking diagonals right-down
                    while (tempRow < n - 1 && tempCol < m - 1)
                    {
                        if (matrix[tempRow, tempCol] == matrix[tempRow + 1, tempCol + 1])
                        {
                            counter++;
                        }
                        else
                        {
                            counter = 1;
                            break;
                        }

                        if (counter > maxLength)
                        {
                            maxLength = counter;
                            mostFrequent = matrix[tempRow, tempCol];
                        }
                        tempRow++;
                        tempCol++;
                    }

                    //=========================================== checking diagonals right-up
                    while (tempRow >= 1 && tempCol < m - 1)
                    {
                        if (matrix[tempRow, tempCol] == matrix[tempRow - 1, tempCol + 1])
                        {
                            counter++;
                        }
                        else
                        {
                            counter = 1;
                            break;
                        }

                        if (counter > maxLength)
                        {
                            maxLength = counter;
                            mostFrequent = matrix[tempRow, tempCol];
                        }
                        tempRow--;
                        tempCol++;
                    }

                }
            }

            //Print result===================================

            Console.WriteLine("Max length is: {0}", maxLength);
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write(mostFrequent + ", ");
            }
            Console.WriteLine();
            
        }
    }
}
