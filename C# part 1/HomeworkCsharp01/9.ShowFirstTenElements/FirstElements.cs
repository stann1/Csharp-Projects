using System;

    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = -1;

            for (int i = 0; i < 10; i++)
            {
                x = x + 2;
                y = y - 2;
               
                Console.WriteLine(x.ToString());
                Console.WriteLine(y.ToString());
                             
            }

        }
    }

