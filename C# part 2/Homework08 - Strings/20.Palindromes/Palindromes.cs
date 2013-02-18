using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _20.Palindromes
{
    class Palindromes
    {
        static bool CheckWord(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            string text = "If you eat bob and go to an ABBA concert, you will earn a level? Wow!";
            string pattern = @"\b\w*\b";

            var words = Regex.Matches(text, pattern);
            foreach (var item in words)
            {
                string word = item.ToString();
                if (word == "")
                {
                    continue;
                }
                bool isPalindrome = CheckWord(word.ToLower());
                if (isPalindrome)
                {
                    Console.WriteLine(word);
                }
            }
        }       
    }
}
