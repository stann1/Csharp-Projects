using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MinimumEditDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "developer";
            string second = "enveloped";
            int firstLen = first.Length;
            int secondLen = second.Length;

            decimal deletionCost = 0.9m;
            decimal insertonCost = 0.8m;
            decimal replacementCost = 1m;

            decimal[,] costs = new decimal[firstLen + 1, secondLen + 1];

            //fill in first row and first col (respectively - deletion and insertion)
            for (int row = 0; row <= firstLen; row++)
            {
                costs[row, 0] = row * deletionCost;
            }

            for (int col = 0; col <= secondLen; col++)
            {
                costs[0, col] = col * insertonCost;
            }

            //fill in the rest of the costs, the final value is in the bottom-right cell
            for (int i = 1; i <= firstLen; i++)
            {
                for (int j = 1; j <= secondLen; j++)
                {
                    if (first[i - 1] == second[j - 1])
                    {
                        costs[i, j] = costs[i - 1, j - 1];
                    }
                    else
                    {
                        decimal delete = costs[i - 1, j] + deletionCost;
                        decimal insert = costs[i, j - 1] + insertonCost;
                        decimal replace = costs[i - 1, j - 1] + replacementCost;
                        costs[i, j] = Math.Min(Math.Min(delete, insert), replace);
                    }
                }
            }

            Console.WriteLine("{0} --> {1}, cost of operations: {2}", first, second, costs[firstLen, secondLen]);
            //PrintCostsTable(costs);
        }

        private static void PrintCostsTable(decimal[,] costs)
        {
            for (int i = 0; i < costs.GetLength(0); i++)
            {
                for (int j = 0; j < costs.GetLength(1); j++)
                {
                    Console.Write("{0,5}", costs[i,j]);
                }
                Console.WriteLine();
            }            
        }
    }
}
