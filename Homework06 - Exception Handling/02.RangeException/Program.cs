using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RangeException
{
    class Program
    {
        static List<int> InputNumbers()
        {
            List<int> inputList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 1 || number >= 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (i > 0 && (number <= inputList[i-1]))
                {
                    throw new ArgumentException();
                }
                inputList.Add(number);                              
            }
            return inputList;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 numbers (1 to 99) in ascending order:");

            try
            {
                List<int> inputs = InputNumbers();
                
                Console.WriteLine("You have entered the numbers:");
                foreach (var element in inputs)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Wrong input! Should be in range [1, 99]");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Numbers should be entered in ascending order!");
            }
        }

        
    }
}
