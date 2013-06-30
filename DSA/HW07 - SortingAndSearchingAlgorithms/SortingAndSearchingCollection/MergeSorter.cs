namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Collection cannot be null");
            }

            var sorted = this.MergeSort(collection);

            for (int i = 0; i < collection.Count; i++)
            {
                collection[i] = sorted[i];
            }
        }

        private IList<T> MergeSort(IList<T> collection)
        {
            if (collection.Count <= 1)
            {
                return collection;
            }

            int midIndex = collection.Count / 2;
            IList<T> left = new List<T>();
            IList<T> right = new List<T>();

            for (int i = 0; i < midIndex; i++)
            {
                left.Add(collection[i]);
            }
            for (int j = midIndex; j < collection.Count; j++)
            {
                right.Add(collection[j]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return this.Merge(left, right);
        }

        private IList<T> Merge(IList<T> left, IList<T> right)
        {
            IList<T> result = new List<T>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0].CompareTo(right[0]) <= 0)
                    {
                        result.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else if (right.Count > 0)
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            return result;
        }
    }
}
