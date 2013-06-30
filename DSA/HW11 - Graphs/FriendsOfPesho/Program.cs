using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsOfPesho
{
    class Program
    {
        static Dictionary<Node, List<Connection>> graph = new Dictionary<Node, List<Connection>>();

        static void Main(string[] args)
        {
            string pointLine = Console.ReadLine();
            string[] mapPoints = pointLine.Split(' ');
            
            int totalPoints = int.Parse(mapPoints[0]);
            int totalConnections = int.Parse(mapPoints[1]);
            int totalHospitals = int.Parse(mapPoints[2]);

            string hospitalLine = Console.ReadLine();
            string[] hospitals = hospitalLine.Split(' ');
            int[] hospitalNumbers = new int[totalHospitals];

            //fill in hospital numbers
            for (int i = 0; i < totalHospitals; i++)
            {
                hospitalNumbers[i] = int.Parse(hospitals[i]);
            }

            Dictionary<int, Node> nodes = new Dictionary<int, Node>();

            //fill in street connections and nodes
            for (int i = 0; i < totalConnections; i++)
            {
                string[] connection = Console.ReadLine().Split(' ');
                int firstNodeId = int.Parse(connection[0]);
                int secondNodeId = int.Parse(connection[1]);
                int distance = int.Parse(connection[2]);

                if (!nodes.ContainsKey(firstNodeId))
                {
                    Node firstNode = new Node(firstNodeId, long.MaxValue);
                    nodes.Add(firstNodeId, firstNode);
                }
                if (!nodes.ContainsKey(secondNodeId))
                {
                    Node secondNode = new Node(secondNodeId, long.MaxValue);
                    nodes.Add(secondNodeId, secondNode);                    
                }

                if (graph.ContainsKey(nodes[firstNodeId]))
                {
                    graph[nodes[firstNodeId]].Add(new Connection(distance, nodes[secondNodeId]));
                }
                else
                {
                    graph.Add(nodes[firstNodeId], new List<Connection>() { new Connection(distance, nodes[secondNodeId]) });
                }

                if (graph.ContainsKey(nodes[secondNodeId]))
                {
                    graph[nodes[secondNodeId]].Add(new Connection(distance, nodes[firstNodeId]));
                }
                else
                {
                    graph.Add(nodes[secondNodeId], new List<Connection>() { new Connection(distance, nodes[firstNodeId]) });
                }
            }

            //test proper input generation
            //foreach (var item in graph)
            //{
            //    Console.Write("Node: {0}, connects to: ", item.Key.PointId);

            //    foreach (var connection in item.Value)
            //    {
            //        Console.Write("node {0}, with distance {1}", connection.Node.PointId, connection.Distance);
            //    }

            //    Console.WriteLine();
            //}

            long bestSum = long.MaxValue;

            for (int i = 0; i < hospitalNumbers.Length; i++)
            {
                long currentSum = 0;
                DijkstraAlgorithm(nodes[hospitalNumbers[i]]);

                //get the sum of all nodes that are not hospitals
                foreach (var item in graph)
                {
                    if (!hospitalNumbers.Contains(item.Key.PointId))
                    {
                        currentSum += item.Key.DijkstraDistance;
                    }
                }

                if (currentSum < bestSum)
                {
                    bestSum = currentSum;
                }
            }

            Console.WriteLine(bestSum);
        }

        public static void DijkstraAlgorithm(Node source)
        {
            var queue = new OtherPriorityQueue<Node>();

            foreach (var item in graph)
            {
                if (source.PointId != item.Key.PointId)
                {
                    item.Key.DijkstraDistance = long.MaxValue;
                }
                
            }

            queue.Enqueue(source);
            source.DijkstraDistance = 0;

            while (queue.Count != 0)
            {
                var currentNode = queue.Dequeue();
                
                foreach (var connection in graph[currentNode])
                {
                    var potDistance = connection.Distance + currentNode.DijkstraDistance;

                    if (potDistance < connection.Node.DijkstraDistance)
                    {
                        connection.Node.DijkstraDistance = potDistance;
                        queue.Enqueue(connection.Node);
                    }
                }
            }
        }
    }
}
