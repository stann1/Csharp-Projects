using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RemoveOddNumbers
{
    class RemoveOdd
    {
        static void Main(string[] args)
        {
            List<int> sequence = new List<int>() { 1, 4, 1, 3, 3, 3, 11, -11, 12, 11 };
            List<int> selection = new List<int>();
            
           
            for (int i = 0; i < sequence.Count; i++)
            {
                int number = sequence[i];

                int count = sequence.FindAll(x => x == number).Count;

                if (count % 2 == 0 && !selection.Contains(number))
                {
                    selection.Add(number);                    
                }
            }

            Console.WriteLine("Elements that occur even number of times:");
            Console.WriteLine(string.Join(", ", selection));
        }
    }
}
