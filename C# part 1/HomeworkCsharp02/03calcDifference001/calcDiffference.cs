using System;

class calcDiffference
{
    static void Main()
    {
        Console.WriteLine("Please input first value:");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Please input second value:");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        bool equalAB = Math.Abs(firstNumber - secondNumber) < 0.000001M;

            if (equalAB == true)
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                Console.WriteLine("Numbers are different!");
            }
    }
}