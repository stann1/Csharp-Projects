using System;

    class nullVariables
    {
        static void Main(string[] args)
        {
            int? firstVar = null;
            double? secondVar = null;
            Console.WriteLine(firstVar);
            Console.WriteLine(secondVar);

            firstVar = 10;
            secondVar = 10.35;
            Console.WriteLine(firstVar.GetValueOrDefault());
            Console.WriteLine(secondVar.GetValueOrDefault());
        }
    }

