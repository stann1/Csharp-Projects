namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("The collection cannot be null");
            }

            int indexMin = 0;

            for (int i = 0; i < collection.Count; i++)
            {
                indexMin = i;
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(collection[indexMin]) < 0)
                    {
                        indexMin = j;
                    }
                }
                if (indexMin != i)
                {
                    Swap(i, indexMin, collection);
                }
            }
        }

        private void Swap<K>(int first, int second, IList<K> collection)
        {
            K oldFirst = collection[first];
            collection[first] = collection[second];
            collection[second] = oldFirst;
        }
    }
}
