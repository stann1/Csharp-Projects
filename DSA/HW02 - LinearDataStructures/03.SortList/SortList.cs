using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SortList
{
    class SortList
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of integers. Enter a blank line to end");
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

                inputs.Add(inputNum);
                inputLine = Console.ReadLine();
                endCommandGiven = inputLine == "";
            }

            
            inputs.Sort();
            Console.WriteLine("The sorted numbers:");
            foreach (var num in inputs)
            {
                Console.WriteLine(num);
            }
        }
    }
}
