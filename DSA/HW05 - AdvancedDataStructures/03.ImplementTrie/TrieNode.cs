using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ImplementTrie
{
    public class TrieNode
    {
        public char Character { get; private set; }

        public bool IsEndNode { get; set; }

        public Dictionary<char, TrieNode> Children { get; private set; }

        public TrieNode(char character)
        {
            this.Character = character;
            this.IsEndNode = false;
            this.Children = new Dictionary<char, TrieNode>();
        }

        public TrieNode GetChildNode(char character)
        {
            if (this.Children.Count != 0 && this.Children.ContainsKey(character))
            {
                return this.Children[character];
            }

            return null;
        }

        public override bool Equals(object obj)
        {
            if (obj is TrieNode)
            {
                if ((obj as TrieNode).Character == this.Character)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            int factor = 43;
            int hash = factor + this.Character.GetHashCode() - 11;
            return hash;
        }
    }
}
