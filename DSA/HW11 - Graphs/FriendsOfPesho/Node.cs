using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsOfPesho
{
    public class Node : IComparable<Node>
    {
        public int PointId { get; set; }

        public long DijkstraDistance { get; set; }

        public Node(int houseNumber, long distance)
        {
            this.PointId = houseNumber;
            this.DijkstraDistance = distance;
        }

        public int CompareTo(Node other)
        {
            return this.DijkstraDistance.CompareTo(other.DijkstraDistance);
        }
    }
}
