using System;
using System.Numerics;
using System.Linq;

namespace _05.Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = input.Length;

            BigInteger[,] matrix = new BigInteger[n + 1, n + 2];
            matrix[0, 0] = 1;                    //case 0 - empty input string

            for (int i = 1; i <= n; i++)
            {
                if (input[i-1] == '(')
                {
                    matrix[i, 0] = 0;
                }
                else
                {
                    matrix[i, 0] = matrix[i - 1, 1];
                }
                for (int j = 1; j <= n; j++)
                {
                    if (input[i-1] == '(')
                    {
                        matrix[i, j] = matrix[i - 1, j - 1];
                    }
                    else if (input[i-1] == ')')
                    {
                        matrix[i, j] = matrix[i - 1, j + 1];
                    }
                    else
                    {
                        matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j + 1];
                    }
                }
            }

            Console.WriteLine(matrix[n, 0]);
        }
    }
}

