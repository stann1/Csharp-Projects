using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation PHP compiler today. " +
                          "It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string words = "PHP, CLR, Microsoft";
            StringBuilder builder = new StringBuilder(text);

            string[] key = words.Split(',');                //create a list of words

            for (int i = 0; i < key.Length; i++)
            {
                key[i] = key[i].Trim();                 //removing empty spaces

                int start = text.IndexOf(key[i], 0);
                string replace = "*";
                for (int mask = 1; mask < key[i].Length; mask++)       //creating mask * with proper length
                {
                    replace += '*';
                }

                while (start != -1)
                {
                    builder.Replace(key[i], replace, start, key[i].Length);       //replace keywords with masks
                    start = text.IndexOf(key[i], start + 1);
                }
            }

            Console.WriteLine(builder.ToString());
        }
    }
}
