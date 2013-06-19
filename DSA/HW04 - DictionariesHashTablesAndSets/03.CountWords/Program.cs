using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This is the TEXT. Text, text, text - THIS TEXT! Is this the text?";
            IDictionary<string, int> dict = new SortedDictionary<string, int>();

            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', '-', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                int counter = 1;
                string wordLowerCase = word.ToLower();

                if (dict.ContainsKey(wordLowerCase))
                {
                    counter = dict[wordLowerCase] + 1;
                }
                dict[wordLowerCase] = counter;
            }

            var orderedDict = dict.OrderBy(x => x.Value);

            foreach (var pair in orderedDict)
            {
                Console.WriteLine("{0} --> {1} times", pair.Key, pair.Value);
            }
        }
    }
}
