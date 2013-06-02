using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ImplementLinkedList
{
    class LinkedListDemo
    {
        static void Main(string[] args)
        {
            CustomLinkedList<int> list = new CustomLinkedList<int>();
            list.AddFirst(3);
            list.AddFirst(5);
            Console.WriteLine(list.FirstElement);
            Console.WriteLine(list.FirstElement.NextItem);

            list.AddLast(8);

            Console.WriteLine("Adding last element and removing the first element:");
            list.RemoveFirst();
            Console.WriteLine(list.FirstElement);
            Console.WriteLine(list.FirstElement.NextItem);

            Console.WriteLine("Removing the last element:");
            list.RemoveLast();
            Console.WriteLine(list.FirstElement);

            Console.WriteLine("Adding 12 after 3:");
            list.AddAfter(new ListItem<int>(3), 12);
            Console.WriteLine(list.FirstElement.NextItem);

            Console.WriteLine("Adding 7 before 12:");
            list.AddBefore(new ListItem<int>(12), 7);

            var current = list.FirstElement;

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.NextItem;
            }
            Console.WriteLine();            
        }
    }
}
