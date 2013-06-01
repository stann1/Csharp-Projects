using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FindFirst50FromQueue
{
    class FindQueueElements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a starting number N:");
            string input = Console.ReadLine();
            int n;
            bool valid = int.TryParse(input, out n);

            if (!valid)
            {
                throw new ArgumentException("The input is not a valid number!");
            }
            
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);
            int index = 0;
            int maxIndex = 49;

            Console.WriteLine("The first 50 queue elements:");
            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                index++;
                Console.Write("{0}, ", current);

                if (index == maxIndex)
                {                    
                    break;
                }
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);
            }
            Console.WriteLine();

        }
    }
}
