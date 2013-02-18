using System;

    class Program
    {
        static void Main(string[] args)
        {
            byte firstVar = 5;
            byte secondVar = 10;

            Console.WriteLine("The value of the first variable is:" + firstVar);
            Console.WriteLine("The value of the second variable is:" + secondVar);

            byte tempVar = firstVar;
            firstVar = secondVar;
            secondVar = tempVar;

            Console.WriteLine("The value of the first variable (after swap) is:" + firstVar);
            Console.WriteLine("The value of the second variable (after swap) is:" + secondVar);
        }
    }
