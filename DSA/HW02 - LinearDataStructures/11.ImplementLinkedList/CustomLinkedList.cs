using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ImplementLinkedList
{
    class CustomLinkedList<T>
    {
        private int nodesCount;

        public ListItem<T> FirstElement { get; private set; }
        public int Count
        {
            get
            {
                return this.nodesCount;
            }
        }
        
        public void AddFirst(T value)
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListItem<T>(value);
            }
            else
            {
                ListItem<T> newItem = new ListItem<T>(value);
                newItem.NextItem = this.FirstElement;
                this.FirstElement = newItem;
            }
            this.nodesCount++;
        }

        public void AddLast(T value)
        {
            if (this.FirstElement == null)
            {
                throw new ArgumentNullException("The list you are trying to access is empty");
            }
            else
            {
                ListItem<T> current = this.FirstElement;

                while (current.NextItem != null)
                {
                    current = current.NextItem;
                }

                current.NextItem = new ListItem<T>(value);
            }
            this.nodesCount++;
        }

        public void AddAfter(ListItem<T> targetItem, T value)
        {
            if (this.FirstElement == null)
            {
                throw new ArgumentNullException("The list you are trying to access is empty");
            }

            ListItem<T> current = this.FirstElement;            

            while ((dynamic)current.Value != (dynamic)targetItem.Value)
            {
                
                current = current.NextItem;
                if (current == null)
                {
                    return;
                }
            }
            
            current.NextItem = new ListItem<T>(value);
            this.nodesCount++;
        }

        public void AddBefore(ListItem<T> targetItem, T value)
        {
            if (this.FirstElement == null)
            {
                throw new ArgumentNullException("The list you are trying to access is empty");
            }

            ListItem<T> current = this.FirstElement;
            
            while ((dynamic)current.NextItem.Value != (dynamic)targetItem.Value)
            {                
                current = current.NextItem;
                if (current == null)
                {
                    return;
                }
            }

            ListItem<T> pushedItem = current.NextItem;
            current.NextItem = new ListItem<T>(value);
            current.NextItem.NextItem = pushedItem;
            this.nodesCount++;
        }

        public void RemoveFirst()
        {
            this.FirstElement = this.FirstElement.NextItem;
            this.nodesCount--;
        }

        public void RemoveLast()
        {
            if (this.FirstElement == null)
            {
                throw new ArgumentNullException("The list you are trying to access is empty");
            }

            ListItem<T> current = this.FirstElement;
            ListItem<T> previous = current;

            while (current.NextItem != null)
            {
                previous = current;
                current = current.NextItem;
            }

            previous.NextItem = null;
            this.nodesCount--;
        }
    }
}
