using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ImplementADTQueue
{
    class QueueItem<T>
    {
        public QueueItem(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public QueueItem<T> NextItem { get; set; }
    }
}
