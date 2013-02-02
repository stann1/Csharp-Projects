using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.AlphabeticalWords
{
    class AlphabeticalWords
    {
        static void Main(string[] args)
        {
            string input = "Some random words seperated by empty spaces";
            string[] words = input.Split(' ');

            Array.Sort(words);

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
