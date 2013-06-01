using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumAndAverageOfSequence
{
    class SumAndAverage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of positive integers. Enter a blank line to end");
            string inputLine = Console.ReadLine();
            bool endCommandGiven = inputLine == "";

            List<int> inputs = new List<int>();

            while (!endCommandGiven)
            {
                int inputNum;
                bool valid = int.TryParse(inputLine, out inputNum);

                if (!valid)
                {
                    throw new ArgumentException("The entered number is not of Int32 type");
                }
                if (inputNum <= 0)
                {
                    throw new ArgumentOutOfRangeException("input number", "The input numbers must be positive");
                }

                inputs.Add(inputNum);
                inputLine = Console.ReadLine();
                endCommandGiven = inputLine == "";
            }

            int sum = 0;

            for (int i = 0; i < inputs.Count; i++)
            {
                sum += inputs[i];
            }

            Console.WriteLine("Sum: {0}, average: {1}", sum, sum / inputs.Count);
        }
    }
}
