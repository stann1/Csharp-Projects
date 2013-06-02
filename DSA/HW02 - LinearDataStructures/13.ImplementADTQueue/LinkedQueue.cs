using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ImplementADTQueue
{
    class LinkedQueue<T>
    {
        private QueueItem<T> firstItem;
        private QueueItem<T> lastItem;
        private int count;

        public int Count
        {
            get { return this.count; }
        }

        public void Enqueue(T value)
        {
            if (firstItem == null)
            {
                firstItem = new QueueItem<T>(value);
                lastItem = firstItem;
            }
            else
            {
                lastItem.NextItem = new QueueItem<T>(value);
                lastItem = lastItem.NextItem;
            }

            count++;
        }

        public T Dequeue()
        {
            if (firstItem == null)
            {
                throw new ArgumentNullException("The queue is empty!");
            }

            T returnItem = firstItem.Value;
            firstItem = firstItem.NextItem;

            return returnItem;
        }

        public T Peek()
        {
            if (firstItem == null)
            {
                throw new ArgumentNullException("The queue is empty!");
            }

            T returnItem = firstItem.Value;           

            return returnItem;
        }
    }
}
