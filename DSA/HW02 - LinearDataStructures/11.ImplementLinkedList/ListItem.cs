using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ImplementLinkedList
{
    class ListItem<T>
    {
        public ListItem(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public ListItem<T> NextItem { get; set; }

        public override string ToString()
        {
            if (this.Value == null)
            {
                return "";
            }
            else
            {
                return this.Value.ToString();
            }
        }
        
    }
}
