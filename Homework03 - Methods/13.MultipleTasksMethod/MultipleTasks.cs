using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MultipleTasksMethod
{
    class MultipleTasks
    {
        static void ReverseNumber()
        {
            Console.WriteLine("Enter a number > 0:");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Wrong input(number must be positive)!");
                return;
            }

            List<int> digitList = new List<int>();
            int reversed = 0;

            for (int i = number; i > 0; i /= 10)
            {
                digitList.Add(i % 10);
            }

            for (int i = digitList.Count - 1, multiplicator = 1; i >= 0; i--, multiplicator *= 10)
            {
                reversed += digitList[i] * multiplicator;
            }

            PrintResult(reversed);

        }

        static void CalculateAverage()
        {
            Console.WriteLine("Enter a sequence length:");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            if (length < 1)
            {
                Console.WriteLine("Wrong input!");
                return;
            }

            int sum = 0;
            Console.WriteLine("Enter a sequence of numbers:");
            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }

            double average = (double)sum / array.Length;

            Console.Write("The average is: ");
            PrintResult(average);

        }

        static void SolveLinearEquation()
        {
            Console.WriteLine("Enter two coefficients A and B:");
            int firstCoeff = int.Parse(Console.ReadLine());
            int secondCoeff = int.Parse(Console.ReadLine());

            if (firstCoeff == 0)
            {
                Console.WriteLine("Coefficient A cannot be 0!");
                return;
            }

            double linearResult = -(double)secondCoeff / firstCoeff;

            Console.Write("X = ");
            PrintResult(linearResult);
        }



        static void PrintResult(double number)
        {
            Console.WriteLine(number);
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Select options: 1 - Reverse digits, 2 - Calculate average of sequence, 3 - Solve linear");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                ReverseNumber();
            }
            else if (option == 2)
            {
                CalculateAverage();
            }
            else if (option == 3)
            {
                SolveLinearEquation();
            }
        }
    }
}
