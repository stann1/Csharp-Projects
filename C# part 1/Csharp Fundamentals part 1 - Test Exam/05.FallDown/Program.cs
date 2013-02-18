using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FallDown
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[8];
            int[,] matrix = new int[8, 8];
            string row;

            for (int i = 0; i < 8; i++)                 //input the data
            {
                inputArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 8; i++)                 //converts the integers into binary
            {
                row = Convert.ToString(inputArray[i], 2).PadLeft(8, '0');
                for (int j = 0; j < 8; j++)
                {
                    matrix[i, j] = int.Parse(row[j].ToString());
                }
            }

            for (int col = 0; col < 8; col++)           //takes cells from each column and sorts the columns
            {
                int[] columnArray = new int[8];
                for (int rowCell = 0; rowCell < 8; rowCell++)
                {
                    columnArray[rowCell] = matrix[rowCell, col];
                }
                Array.Sort(columnArray);
                for (int i = 0; i <8; i++)
                {
                    matrix[i, col] = columnArray[i];
                }
            }

            for (int i = 0; i < 8; i++)                 //returns output in string format
            {
                string outputRow = "";
                for (int j = 0; j < 8; j++)
                {
                    outputRow += matrix[i, j];
                }
                Console.WriteLine(Convert.ToInt64(outputRow, 2));
            }
        }
    }
}
