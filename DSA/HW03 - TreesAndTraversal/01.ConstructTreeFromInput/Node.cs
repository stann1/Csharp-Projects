using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ConstructTreeFromInput
{
    class Node<T>
    {
        public Node()
        {
            this.Children = new List<Node<T>>();
        }

        public Node(T value) : this()
        {
            this.Value = value;            
        }

        public T Value { get; set; }

        public bool HasParent { get; set; }        

        public List<Node<T>> Children { get; set; }

        public Node<T> Parent { get; set; }
    }
}
