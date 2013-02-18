using System;


namespace _03.ExcelColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] inputChars = new char[n];
            long result = 0;

            int[] inputNumber = new int[n];

            for (int i = 0; i < n; i++)
            {
                inputChars[i] = char.Parse(Console.ReadLine());
                inputNumber[i] = (int)inputChars[i] - 64;
            }

            for (int i = 0; i < n; i++)
            {
                result += (long)Math.Pow(26, i) * inputNumber[n - i - 1];
            }
            Console.WriteLine(result);
        }
    }
}
