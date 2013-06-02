using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ImplementADTStack
{
    class CustomStack<T>
    {
        private T[] stack;
        private int topIndex;

        public CustomStack()
        {
            this.stack = new T[1];
            this.topIndex = -1;
        }

        public int Count
        {
            get
            {
                return this.topIndex + 1;
            }            
        }

        public void Push(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("The provided value is null");
            }

            int length = this.stack.Length;

            if (topIndex == length - 1)
            {
                this.ResizeArray(length);
            }

            topIndex++;
            this.stack[topIndex] = value;            
        }

        public T Pop()
        {
            if (this.topIndex < 0)
            {
                throw new ArgumentNullException("The stack contains no elements");
            }

            T topElement = this.stack[this.topIndex];            
            this.topIndex--;

            return topElement;
        }

        public T Peek()
        {
            if (this.topIndex < 0)
            {
                throw new ArgumentNullException("The stack contains no elements");
            }

            T topElement = this.stack[this.topIndex];
            return topElement;
        }

        //private methods for the class
        private void ResizeArray(int currentLength)
        {
            T[] newStack = new T[currentLength * 2];

            for (int i = 0; i < currentLength; i++)
            {
                newStack[i] = this.stack[i];
            }

            this.stack = newStack;
        }
    }
}
