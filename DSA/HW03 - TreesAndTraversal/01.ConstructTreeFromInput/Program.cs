using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ConstructTreeFromInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var nodes = new Node<int>[n];

            for (int i = 0; i < n; i++)
            {
                nodes[i] = new Node<int>(i);
            }

            for (int i = 1; i < n; i++)
            {
                string edgeAsString = Console.ReadLine();
                var edgeParts = edgeAsString.Split(' ');

                int parentId = int.Parse(edgeParts[0]);
                int childId = int.Parse(edgeParts[1]);

                nodes[parentId].Children.Add(nodes[childId]);
                nodes[childId].HasParent = true;
                nodes[childId].Parent = nodes[parentId];
            }

            // 1.Finding the root
            int rootIndex = 0;
            for (int i = 0; i < n; i++)
            {
                if (!nodes[i].HasParent)
                {
                    rootIndex = i;
                    break;
                }
            }

            Console.WriteLine("Root: {0}", nodes[rootIndex].Value);

            // 2.Finding all leaf nodes
            Console.Write("Leaf nodes: ");
            for (int i = 0; i < n; i++)
            {
                if (nodes[i].HasParent && nodes[i].Children.Count == 0)
                {
                    Console.Write(nodes[i].Value + (i == n-1 ? "" : ", "));
                }
            }
            Console.WriteLine();

            // 3.Finding all middle nodes
            Console.Write("Middle nodes: ");
            for (int i = 0; i < n; i++)
            {
                if (nodes[i].HasParent && nodes[i].Children.Count != 0)
                {
                    Console.Write(nodes[i].Value + (i == n - 1 ? "" : ", "));
                }
            }
            Console.WriteLine();

            // 4.Finding the longest path
            var root = nodes[rootIndex];

            int longest = FindLongestPath(root);
            Console.WriteLine("The longest path strting from the root: {0}", longest);

        }

        private static int FindLongestPath(Node<int> root)
        {
            if (root.Children.Count == 0)
            {                
                return root.Value;
            }
            else
            {
                int maxValue = 0;
                for (int i = 0; i < root.Children.Count; i++)
                {
                    int childValue = FindLongestPath(root.Children[i]);
                    if (childValue > maxValue)
                    {
                        maxValue = childValue;
                    }
                }

                return root.Value + maxValue;
            }
        }
    }
}
