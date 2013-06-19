using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ImplementPriorityQueue
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            CustomPriorityQueue<int> queue = new CustomPriorityQueue<int>();

            queue.Enqueue(11);
            queue.Enqueue(5);
            queue.Enqueue(8);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(15);

            Console.WriteLine("Queue after adding 15:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

           
            int topPriority = queue.Dequeue();
            topPriority = queue.Dequeue();

            Console.WriteLine("Queue after dequeue two times:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
