using System;

namespace _04.TelerikLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z = (x + 1) / 2;
            int maxLength = 3 * x - 2;
            int y = z;

            for (int i = 1; i <= maxLength; i++)
            {
                for (int j = 1; j <= maxLength; j++)
                {
                    if (j == z || j == maxLength - z + 1 || j == y || j == maxLength - y + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                if (i < 2*x - 1)
                {
                    y++; 
                }
                else
                {
                    y--;
                }
                z--;
                Console.WriteLine();
            }
        }
    }
}
