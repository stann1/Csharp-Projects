namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            foreach (T element in this.items)
            {
                if (element.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public bool BinarySearch(T item)
        {
            int indexOfItem = BinarySearchRecursive(item, 0, this.items.Count - 1);
            if (indexOfItem > -1)
            {
                return true;
            }
            return false;
        }

        private int BinarySearchRecursive(T item, int minIndex, int maxIndex)
        {
            if (maxIndex <= minIndex)
            {
                return -1;
            }

            int middleIndex = (minIndex + maxIndex) / 2;
            if (this.items[middleIndex].CompareTo(item) > 0)
            {
                return BinarySearchRecursive(item, minIndex, middleIndex - 1);
            }
            else if (this.items[middleIndex].CompareTo(item) < 0)
            {
                return BinarySearchRecursive(item, middleIndex + 1, maxIndex);
            }
            else
            {
                return middleIndex;
            }
        }

        /// <summary>
        /// Randomizes the collection. The algorithm complexity is O(n + n), each element is shuffled only once, 
        /// in addition we need n steps for the random generator.
        /// </summary>
        public void Shuffle()
        {
            Random randGenerator = new Random();

            for (int i = 0; i < this.items.Count; i++)
            {
                int randIndex = randGenerator.Next(1, this.items.Count - i);
                var temp = this.items[randIndex];
                this.items[randIndex] = this.items[0];
                this.items[0] = temp;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
