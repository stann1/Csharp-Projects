using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.ImplementTrie
{
    class TrieDemo
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            Stopwatch sw = new Stopwatch();

            sw.Start();
            List<string> wordsFromText = GetWordsFromText();
            sw.Stop();
            Console.WriteLine("Word extraction finished in {0}", sw.Elapsed);

            List<string> wordsToSearch = new List<string>();
            int numberOfWords = 100;

            int len = numberOfWords < wordsFromText.Count ? numberOfWords : wordsFromText.Count;

            for (int i = 0; i < len; i++)
			{
                wordsToSearch.Add(wordsFromText[i]);			 
			}

            AddWordsUsingTrie(trie, wordsFromText, sw);
            AddWordsUsingDict(dict, wordsFromText, sw);

            FindWordsUsingTrie(trie, wordsToSearch, sw);
            FindWordsUsingDict(dict, wordsToSearch, sw);
        }

        private static void FindWordsUsingDict(Dictionary<string, int> dict, List<string> wordsToSearch, Stopwatch sw)
        {
            sw.Restart();
            foreach (string word in wordsToSearch)
            {
                int count = dict[word];
                //Console.WriteLine("word: {0}, count: {1}", word, count);
            }
            sw.Stop();
            Console.WriteLine("Searching {0} words in Dictionary finished in: {1} time", wordsToSearch.Count, sw.Elapsed);
        }

        private static void FindWordsUsingTrie(Trie trie, List<string> wordsToSearch, Stopwatch sw)
        {
            sw.Restart();
            foreach (string word in wordsToSearch)
            {
                int count = trie.GetWordCount(word);
                //Console.WriteLine("word: {0}, count: {1}", word, count);
            }
            sw.Stop();
            Console.WriteLine("Searching {0} words in Trie finished in: {1} time", wordsToSearch.Count, sw.Elapsed);
        }

        private static void AddWordsUsingDict(Dictionary<string, int> dict, List<string> wordsFromText, Stopwatch sw)
        {
            sw.Restart();
            foreach (string word in wordsFromText)
            {
                dict[word] = 0;
            }
            sw.Stop();

            Console.WriteLine("{0} words added to Dictionary in: {1} time", wordsFromText.Count, sw.Elapsed);
        }

        private static void AddWordsUsingTrie(Trie trie, List<string> wordsFromText, Stopwatch sw)
        {
            sw.Restart();
            foreach (string word in wordsFromText)
            {
                trie.Insert(word);
            }
            sw.Stop();

            Console.WriteLine("{0} words added  to Trie in: {1} time", wordsFromText.Count, sw.Elapsed);
        }

        private static List<string> GetWordsFromText()
        {
            //Only a small file is included in the archive for saving space. Using a large text file of 100mb hangs the system, 
            //use smaller one around 20mb.
            StreamReader reader = new StreamReader(@"..\..\text.txt");
            List<string> wordsFromText = new List<string>();

            using (reader)
            {
                string fullText = reader.ReadToEnd();

                var words = Regex.Matches(fullText, @"\b\w+\b");
                foreach (var word in words)
                {
                    wordsFromText.Add(word.ToString());
                }
            }

            return wordsFromText;
        }
    }
}
