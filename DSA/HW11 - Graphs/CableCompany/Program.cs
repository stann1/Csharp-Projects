using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            int nodes = 6;
            SortedSet<Edge> priority = new SortedSet<Edge>();
            bool[] used = new bool[nodes + 1];
            List<Edge> mpdNodes = new List<Edge>();
            List<Edge> edges = new List<Edge>();

            //initialize the edges
            edges.Add(new Edge(1, 3, 5));
            edges.Add(new Edge(1, 2, 4));
            edges.Add(new Edge(1, 4, 9));
            edges.Add(new Edge(2, 4, 2));
            edges.Add(new Edge(3, 4, 20));
            edges.Add(new Edge(3, 5, 7));
            edges.Add(new Edge(4, 5, 8));
            edges.Add(new Edge(5, 6, 12));

            //adding edges that connect the node 1 with all the others
            for (int i = 0; i < nodes; i++)
            {
                if (edges[i].StartNode == edges[0].StartNode)
                {
                    priority.Add(edges[i]);
                }
            }
            used[edges[0].StartNode] = true;

            FindMinimumSpanningTree(priority, used, mpdNodes, edges);

            for (int i = 0; i < mpdNodes.Count; i++)
            {
                Console.WriteLine(mpdNodes[i]);
            }
        }

        private static void FindMinimumSpanningTree(SortedSet<Edge> priority, bool[] used, List<Edge> mpdNodes, List<Edge> edges)
        {
            while (priority.Count > 0)
            {
                Edge minEdge = priority.Min;
                priority.Remove(minEdge);

                //check to avoid falling back into loop
                if (!used[minEdge.EndNode])
                {
                    used[minEdge.EndNode] = true;
                    mpdNodes.Add(minEdge);
                    AddEdges(minEdge, edges, mpdNodes, priority, used);         //adds the edge at the end of the set, so that it can be checked again
                }
            }
        }

        private static void AddEdges(Edge edge, List<Edge> edges, List<Edge> mpd, SortedSet<Edge> priority, bool[] used)
        {
            for (int i = 0; i < edges.Count; i++)
            {
                if (!mpd.Contains(edges[i]))
                {
                    if (edge.EndNode == edges[i].StartNode && !used[edges[i].EndNode])
                    {
                        priority.Add(edges[i]);
                    }
                }
            }
        }

    }
}
