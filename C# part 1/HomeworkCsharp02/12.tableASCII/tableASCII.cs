using System;

    class tableASCII
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i < 128; i++)
            {
                char symbolASCII = (char)i;
                Console.WriteLine("character {0} is: {1}", i, symbolASCII);
            }
        }
    }

