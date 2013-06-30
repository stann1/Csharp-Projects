namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("The collection cannot be null");
            }

            this.QuickSort(collection, 0, collection.Count - 1);
        }

        private void QuickSort(IList<T> collection, int startIndex, int endIndex)
        {
            if (endIndex <= startIndex)
            {
                return;
            }

            int pivotIndex = startIndex + (endIndex - startIndex) / 2;

            int newPivotIndex = this.Partition(collection, startIndex, endIndex, pivotIndex);
            QuickSort(collection, startIndex, newPivotIndex - 1);
            QuickSort(collection, newPivotIndex + 1, endIndex);
        }

        private int Partition(IList<T> collection, int startIndex, int endIndex, int pivotIndex)
        {
            T pivotValue = collection[pivotIndex];
            Swap(pivotIndex, endIndex, collection);

            int storeIndex = startIndex;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (collection[i].CompareTo(pivotValue) <= 0)
                {
                    Swap(i, storeIndex, collection);
                    storeIndex++;
                }
            }

            Swap(storeIndex, endIndex, collection);

            return storeIndex;
        }

        private void Swap<K>(int first, int second, IList<K> collection)
        {
            K oldFirst = collection[first];
            collection[first] = collection[second];
            collection[second] = oldFirst;
        }
    }
}
