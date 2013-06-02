using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Labyrinth
{
    class Labyrinth
    {
        static string[,] matrix = new string[,]
                                    {
                                        {"0", "0", "0", "x", "0", "x"},
                                        {"0", "x", "0", "x", "0", "x"},
                                        {"0", "*", "x", "0", "x", "0"},
                                        {"0", "x", "0", "0", "0", "0"},
                                        {"0", "0", "0", "x", "x", "0"},
                                        {"0", "0", "0", "x", "0", "x"},
                                    };
        static int size = matrix.GetLength(0);
        static bool[,] visited = new bool[size, size];
        static int startingPosX = 2;
        static int startingPosY = 1;

        static void Main(string[] args)
        {
            FindShortestPathToCells(startingPosX, startingPosY, 0);
            FillInUnreachableCells();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
       
        private static void FindShortestPathToCells(int currentPosX, int currentPosY, int currentSteps)
        {
            //check if outside the matrix
            if (currentPosX < 0 || currentPosX >= size || currentPosY < 0 || currentPosY >= size)
            {
                return;
            }

            string currentCell = matrix[currentPosX, currentPosY];

            //check if traversable cell
            if (currentCell == "x" || RevisitedStartingCell(currentCell, currentPosX, currentPosY))
            {
                return;
            }            

            //Check if current cell is different than starting cell
            if (currentCell != "*")
            {
                currentSteps++;
                int currentCellValue = int.Parse(currentCell);
                
                if (ShorterPathExists(currentPosX, currentPosY, currentCellValue, currentSteps))
                {
                    return;
                }

                matrix[currentPosX, currentPosY] = currentSteps.ToString();
            }           

            visited[currentPosX, currentPosY] = true;            
            TraverseAdjacentCells(currentPosX, currentPosY, currentSteps);
        } 

        private static void TraverseAdjacentCells(int currentPosX, int currentPosY, int currentSteps)
        {
            FindShortestPathToCells(currentPosX - 1, currentPosY, currentSteps);        //up
            FindShortestPathToCells(currentPosX, currentPosY + 1, currentSteps);        //right
            FindShortestPathToCells(currentPosX + 1, currentPosY, currentSteps);        //down
            FindShortestPathToCells(currentPosX, currentPosY - 1, currentSteps);        //left
        }

        private static bool RevisitedStartingCell(string currentCell, int currentPosX, int currentPosY)
        {
            if (visited[currentPosX,currentPosY] && currentCell == "*")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ShorterPathExists(int currentPosX, int currentPosY, int currentCellValue, int currentSteps)
        {
            //check if already found shorter path
            if (visited[currentPosX, currentPosY])
            {
                if (currentCellValue < currentSteps)
                {
                    return true;
                }
            }
            return false;
        }

        private static void FillInUnreachableCells()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i,j] == "0")
                    {
                        matrix[i, j] = "u";
                    }
                }
            }
        }

    }
}
