using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ImplementADTStack
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            CustomStack<int> myStack = new CustomStack<int>();
            Console.WriteLine("Elements count: {0}", myStack.Count);
            myStack.Push(2);
            Console.WriteLine("Elements count: {0}", myStack.Count);
            int last = myStack.Peek();
            Console.WriteLine("Last element peek: {0}", last);
            Console.WriteLine("Elements count after peek: {0}", myStack.Count);
            int removed = myStack.Pop();
            Console.WriteLine("Elements count after pop: {0}", myStack.Count);
        }
    }
}
