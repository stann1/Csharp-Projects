using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.VariableType
{
    class VariableType
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your variable type:");
            Console.WriteLine("1 - for int, 2 - for double, 3 - for string");
            byte inputType = byte.Parse(Console.ReadLine());

            switch (inputType)
            {
                case 1: Console.Write("Please enter your int variable:");
                    int inputInt = int.Parse(Console.ReadLine());
                    inputInt++;
                    Console.WriteLine("New value:" + inputInt);
                    break;
                case 2: Console.Write("Please enter your double variable:");
                    double inputDouble = double.Parse(Console.ReadLine());
                    inputDouble++;
                    Console.WriteLine("New value:" + inputDouble);
                    break;
                case 3: Console.Write("Please enter your string variable:");
                    string inputString = Console.ReadLine();
                    Console.WriteLine("New value:" + inputString + "*");
                    break;
                default: Console.WriteLine("This is not a valid choice: please enter 1, 2 or 3");
                    break;
            }
        }
    }
}
