using System;

namespace _03.FirTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int maxLength = 2 * (height - 1);

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j < maxLength; j++)
                {
                    if (i == 1 || i == height)          //first and last rows
                    {
                        if (j == maxLength / 2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    else
                    {
                        if ((j >= maxLength/2 - (i-1)) && (j <= maxLength/2 + (i-1)))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
