using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ForestRoad
{
    class ForestRoad
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int position = 0; position < n; position++)    //from left to right side
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == position)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                } Console.WriteLine();
            }

            for (int position = n - 2; position >= 0; position--)    //from right to left side
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == position)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                } Console.WriteLine();
            }
        }
    }
}
