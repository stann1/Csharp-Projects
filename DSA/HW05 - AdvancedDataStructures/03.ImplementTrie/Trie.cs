using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ImplementTrie
{
    public class Trie
    {
        private TrieNode root;

        private Dictionary<string, int> wordCount;

        public Trie()
        {
            this.root = new TrieNode(' ');
            this.wordCount = new Dictionary<string, int>();
        }

        public void Insert(string word)
        {
            char[] characters = word.ToLower().ToCharArray();

            if (characters.Length == 0)
            {
                this.root.IsEndNode = true;
            }

            TrieNode currentNode = this.root;
            
            for (int i = 0; i < characters.Length; i++)
            {
                TrieNode child = currentNode.GetChildNode(characters[i]);
                                
                if (child != null)
                {
                    currentNode = child;
                }
                else
                {
                    currentNode.Children.Add(characters[i], new TrieNode(characters[i]));
                    currentNode = currentNode.GetChildNode(characters[i]);
                }

                if (i == characters.Length - 1)
                {
                    currentNode.IsEndNode = true;
                }
            }

            this.RegisterWordCount(word);
        }

        public bool Contains(string word)
        {
            char[] characters = word.ToLower().ToCharArray();

            TrieNode currentNode = this.root;
            if (currentNode != null)
            {
                for (int i = 0; i < characters.Length; i++)
                {
                    TrieNode child = currentNode.GetChildNode(characters[i]);
                    if (child == null)
                    {
                        return false;
                    }
                    else
                    {
                        currentNode = child;
                    }
                }

                if (currentNode.IsEndNode)
                {
                    return true;
                }   
            }

            return false;
        }

        public int GetWordCount(string word)
        {
            if (this.Contains(word))
            {
                return this.wordCount[word];
            }

            return 0;
        }

        private void RegisterWordCount(string word)
        {
            if (wordCount.ContainsKey(word))
            {
                int count = wordCount[word];
                wordCount[word] = count + 1;
            }
            else
            {
                wordCount.Add(word, 1);
            }
        }
    }
}
