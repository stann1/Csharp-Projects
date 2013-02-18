using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ReturnMinMax
{
    class ReturnMinMax
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number > 0");
            int sequenceN = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter {0} numbers on the console", sequenceN);
            int[] inputNumbers = new int[sequenceN];

            for (int i = 0; i < sequenceN; i++)
            {
                string lastInput = Console.ReadLine();
                inputNumbers[i] = int.Parse(lastInput);

            }
            Console.WriteLine("Min = {0}, Max = {1}",inputNumbers.Min(), inputNumbers.Max());
        }
    }
}
