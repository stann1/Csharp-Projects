using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CheckOccurances
{
    class CheckOccurances
    {
        static void Main(string[] args)
        {
            List<int> sequence = new List<int>() { 1, 4, 1, 3, 3, 3, 11, 11, 12, 11 };
            Dictionary<int, int> selection = new Dictionary<int, int>();
            List<int> checkedNumbers = new List<int>();


            for (int i = 0; i < sequence.Count; i++)
            {
                int number = sequence[i];

                int count = sequence.FindAll(x => x == number).Count;

                //To avoid repetition, perform a check if the number has been found already
                if (!checkedNumbers.Contains(number))
                {
                    selection.Add(number, count);
                    checkedNumbers.Add(number);
                }
            }

            Console.WriteLine("The elements with corresponding number of occurances:");
            foreach (var element in selection)
            {
                Console.WriteLine("Number: {0}, found {1} time(s)", element.Key, element.Value);
            }
        }
    }
}
