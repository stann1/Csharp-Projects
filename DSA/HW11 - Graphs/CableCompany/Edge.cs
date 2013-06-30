using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableCompany
{
    class Edge : IComparable<Edge>
    {
        public int StartNode { get; set; }
        public int EndNode { get; set; }
        public int Weight { get; set; }
        
        public Edge(int startNode, int endNode, int weight)
        {
            this.StartNode = startNode;
            this.EndNode = endNode;
            this.Weight = weight;
        }

        public int CompareTo(Edge other)
        {
            int weight = this.Weight.CompareTo(other.Weight);

            if (weight == 0)
            {
                weight = this.StartNode.CompareTo(other.StartNode);
            }

            return weight;
        }

        public override string ToString()
        {
            return String.Format("Edge from {0} to {1}, with length {2}", this.StartNode, this.EndNode, this.Weight);
        }
    }
}
