using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitBall
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixT = new int[8, 8];
            int[,] matrixB = new int[8, 8];
            int[,] matrixJoin = new int[8, 8];
            int scoreT = 0;
            int scoreB = 0;

            for (int row = 0; row < 8; row++)           //team T
            {
                int n = int.Parse(Console.ReadLine());
                for (int column = 0; column < 8; column++)
                {
                    if (((n >> column) & 1) == 1)
                    {
                        matrixT[row, column] = 1;
                        matrixJoin[row, column] = 1;
                    }
                    
                }
            }
            for (int row = 0; row < 8; row++)           //team B
            {
                int n = int.Parse(Console.ReadLine());
                for (int column = 0; column < 8; column++)
                {
                    if (((n >> column) & 1) == 1)
                    {
                        matrixB[row, column] = 1;
                    }
                    if (matrixB[row, column] == 1)
                    {
                        if (matrixJoin[row, column] == 1)
                        {
                            matrixJoin[row, column] = 0;
                        }
                        else
                        {
                            matrixJoin[row, column] = 1;
                        }
                    }

                }
            }

           /* for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(matrixJoin[i, j]);
                }
                Console.WriteLine();
            }
            */

            for (int col = 0; col < 8; col++)
            {
                for (int row = 0; row < 8; row++)       //scoring for team T
                {
                    if (matrixT[row, col] == 1 && matrixJoin[row, col] == 1)        
                    {
                        if (row == 7)
                        {
                            scoreT++;
                            break;
                        }
                        else
                        {
                            while (matrixJoin[row + 1, col] == 0)
                            {
                                row++;
                                if (row == 7)
                                {
                                    scoreT++;
                                    break;
                                }
                            }
                        }
                    }
                }

                for (int row = 7; row >= 0; row--)       //scoring for team B
                {
                    if (matrixB[row, col] == 1 && matrixJoin[row, col] == 1)
                    {
                        if (row == 0)
                        {
                            scoreB++;
                            break;
                        }
                        while (matrixJoin[row - 1, col] == 0)
                        {
                            row--;
                            if (row == 0)
                            {
                                scoreB++;
                                break;
                            }
                        }
                    }

                }
            }

            Console.WriteLine("{0}:{1}", scoreT, scoreB);
        }  
    }
}
