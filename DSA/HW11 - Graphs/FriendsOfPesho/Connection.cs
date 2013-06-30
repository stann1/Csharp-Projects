using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsOfPesho
{
    class Connection
    {
        public long Distance { get; set; }

        public Node Node { get; set; }

        public Connection(long distance, Node node)
        {
            this.Distance = distance;
            this.Node = node;
        }
    }
}
