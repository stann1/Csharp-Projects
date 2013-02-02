using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.CountWords
{
    class CountWords
    {
        static void Main(string[] args)
        {
            //string text = "This is some random text, to test some random thing for some purpose!";
            Console.WriteLine("Enter some text:");
            string text = Console.ReadLine();

            char[] seperators = { '.', ',', ':', ';', '?', '!', ' '};
            string[] words = text.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(words);
            int counter = 0;

            Console.WriteLine("Different words : count");
            for (int i = 0; i < words.Length; i++)
            {
                counter++;
                if (i < words.Length - 1 && words[i] == words[i+1])
                {
                    
                    continue;
                }
                else
                {
                    Console.WriteLine("{0} : {1}", words[i], counter);
                    counter = 0;
                }
            }
        }
    }
}
