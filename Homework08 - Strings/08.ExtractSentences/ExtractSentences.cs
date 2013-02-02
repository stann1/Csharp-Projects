using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. " +
                          "Inside the submarine is very tight. So we are drinking all the day. " +
                          "We will move out of it in 5 days.";
            string word = "in";
            string[] sentences = text.Split('.');
                                    
            for (int i = 0; i < sentences.Length; i++)
            {
                
                bool contains = CheckSubstrings(sentences[i], word);
                if (contains)
                {
                    Console.WriteLine((sentences[i] + '.').Trim());
                }
            }

        }

        static bool CheckSubstrings(string sentence, string word)
        {
            sentence = sentence.ToLower();
            string pattern = @"\s*(\b" + word + @"\b.*)";
                        
            if (Regex.Match(sentence, pattern) != Match.Empty)
            {
                return true;
            }

            return false;
        }
    }
}
