using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRootException
{
    class Program
    {
        static double GetSqrt(double number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return Math.Sqrt(number);
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number");
            
            try
            {
                double number = double.Parse(Console.ReadLine());
                double result = GetSqrt(number);
                Console.WriteLine("Square root of {0}: {1}", number, result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");                
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number!");                
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }

        
    }
}
