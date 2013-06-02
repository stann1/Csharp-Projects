using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ImplementADTQueue
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            LinkedQueue<int> myQueue = new LinkedQueue<int>();
            myQueue.Enqueue(3);
            myQueue.Enqueue(8);
            myQueue.Enqueue(12);
            Console.WriteLine("Current count: {0}", myQueue.Count);

            int first = myQueue.Dequeue();
            Console.WriteLine("First element removed from queue: {0}", first);
            int second = myQueue.Dequeue();
            Console.WriteLine("Second element removed from queue: {0}", second);
            Console.WriteLine("First element in the new queue: {0}", myQueue.Peek());
        }
    }
}
