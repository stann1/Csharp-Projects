using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RemoveNegative
{
    class RemoveNegatives
    {
        static void Main(string[] args)
        {
            List<int> sequence = new List<int>() { 1, 4, 1, 3, 3, 3, 11, -11, 11, 11 };

            sequence.RemoveAll(x => x < 0);

            Console.WriteLine("Non-negative elements:");
            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
