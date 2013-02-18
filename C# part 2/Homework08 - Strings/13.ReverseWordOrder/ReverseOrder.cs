using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _13.ReverseWordOrder
{
    class ReverseOrder
    {
        static void Main(string[] args)
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            char[] seperators = {' ', ',', '.', '!', '?', ':', ';'};
            StringBuilder output = new StringBuilder();
            string[] words = sentence.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);

            string pattern = "[A-Za-z0-9#+]";                  //this expression will match every character except alphanumeric (and #, +)
            string[] chars = Regex.Split(sentence, pattern);
            List<string> punctuation = new List<string>();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != String.Empty)
                {
                    punctuation.Add(chars[i]);
                }                
            }

            for (int i = 0; i < punctuation.Count; i++)
            {
                if (i < words.Length)
                {
                    output.Append(words[i]);
                }                
                output.Append(punctuation[i]);
            }

            Console.WriteLine(output.ToString());
            
        }
    }
}
