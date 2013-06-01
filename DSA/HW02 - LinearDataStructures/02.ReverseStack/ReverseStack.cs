using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseStack
{
    class ReverseStack
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of integers. Enter a blank line to end");
            string inputLine = Console.ReadLine();
            bool endCommandGiven = inputLine == "";

            Stack<int> inputs = new Stack<int>();

            while (!endCommandGiven)
            {
                int inputNum;
                bool valid = int.TryParse(inputLine, out inputNum);

                if (!valid)
                {
                    throw new ArgumentException("The entered number is not of Int32 type");
                }
                
                inputs.Push(inputNum);
                inputLine = Console.ReadLine();
                endCommandGiven = inputLine == "";
            }

            Console.WriteLine("The numbers reversed:");
            int len = inputs.Count;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(inputs.Pop());
            }
        }
    }
}
