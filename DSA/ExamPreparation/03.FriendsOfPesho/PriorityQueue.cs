using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This implementation is slower, if it is used instead of OtherPriorityQueue the points in bgcoder are 70/100
namespace FriendsOfPesho
{
    public class PriorityQueue<T> : IEnumerable<T> where T : IComparable<T>
    {
        private List<T> heap;
        private int elementCount;

        public PriorityQueue()
        {
            this.heap = new List<T>();
            this.elementCount = 0;
        }

        public int Count
        {
            get { return this.elementCount; }
        }

        //public methods
        public void Enqueue(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("The element to enque cannot be null");
            }

            this.heap.Add(element);
            this.SiftUp();
            this.elementCount++;
        }

        public T Dequeue()
        {
            if (this.elementCount == 0)
            {
                throw new ArgumentOutOfRangeException("The queue is empty!");
            }

            T elementToReturn = this.heap[0];
            this.heap[0] = this.heap[this.elementCount - 1];
            this.heap.RemoveAt(this.elementCount - 1);
            this.elementCount--;
            this.SiftDown();
            return elementToReturn;
        }

        public T Peek()
        {
            return this.heap[0];
        }

        //private methods
        private void SiftUp()
        {
            int currentIndex = this.elementCount;
            int parentIndex = (currentIndex - 1) / 2; //Check "binary heap" in wikipedia for detailed explanation

            this.RearrangeHeapBottomUp(currentIndex, parentIndex);
        }

        private void SiftDown()
        {
            int currentIndex = 0;
            int leftChildIndex = 2 * currentIndex + 1;
            int rightChildIndex = 2 * currentIndex + 2;

            this.RearrangeHeapFromTop(currentIndex, leftChildIndex, rightChildIndex);
        }

        private void RearrangeHeapFromTop(int currentIndex, int leftChildIndex, int rightChildIndex)
        {
            if (leftChildIndex >= this.elementCount || rightChildIndex >= this.elementCount)
            {
                return;
            }
            if (this.heap[currentIndex].CompareTo(this.heap[leftChildIndex]) >= 0 &&
                this.heap[currentIndex].CompareTo(this.heap[rightChildIndex]) >= 0)
            {
                return;
            }

            int indexOfLargerChild = 0;

            if (this.heap[leftChildIndex].CompareTo(this.heap[rightChildIndex]) == 1)
            {
                indexOfLargerChild = leftChildIndex;
            }
            else
            {
                indexOfLargerChild = rightChildIndex;
            }

            T largerChild = this.heap[indexOfLargerChild];
            this.heap[indexOfLargerChild] = this.heap[currentIndex];
            this.heap[currentIndex] = largerChild;

            currentIndex = indexOfLargerChild;
            leftChildIndex = 2 * currentIndex + 1;
            rightChildIndex = 2 * currentIndex + 2;

            RearrangeHeapFromTop(currentIndex, leftChildIndex, rightChildIndex);
        }

        private void RearrangeHeapBottomUp(int currentIndex, int parentIndex)
        {
            if (currentIndex <= 0)
            {
                return;
            }
            if (this.heap[currentIndex].CompareTo(this.heap[parentIndex]) < 0)
            {
                return;
            }

            T tempEl = this.heap[parentIndex];
            this.heap[parentIndex] = this.heap[currentIndex];
            this.heap[currentIndex] = tempEl;

            currentIndex = parentIndex;
            parentIndex = (currentIndex - 1) / 2;

            RearrangeHeapBottomUp(currentIndex, parentIndex);
        }



        //Interface methods
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in heap)
            {
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
