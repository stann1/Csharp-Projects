using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using _04.ImplementHashTable;

namespace _05.ImplementHashSet
{
    public class CustomHashSet<T> : IEnumerable<T>
    {
        private CustomHashTable<T, int> hashTable;

        public CustomHashSet(params T[] values)
        {
            this.hashTable = new CustomHashTable<T, int>();

            if (values != null)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    this.hashTable.Add(values[i], 1);
                }
            }
        }

        public int Count
        {
            get
            {
                return this.hashTable.CurrentCount;
            }
        }

        public void Add(T value)
        {
            this.hashTable.Add(value, 1);
        }

        public void Remove(T value)
        {
            this.hashTable.Remove(value);
        }

        public void Clear()
        {
            this.hashTable.Clear();
        }

        public int Find(T value)
        {
            return this.hashTable.Find(value);
        }

        public bool Contains(T value)
        {
            return this.hashTable.Contains(value);
        }

        public void UnionWith(CustomHashSet<T> otherSet)
        {
            foreach (var item in otherSet)
            {
                if (!this.Contains(item))
                {
                    this.hashTable.Add(item, 1);
                }                
            }
        }

        public void IntersectionWith(CustomHashSet<T> otherSet)
        {
            CustomHashTable<T, int> intersection = new CustomHashTable<T,int>();

            foreach (var item in otherSet)
            {
                if (this.hashTable.Contains(item))
                {
                    intersection.Add(item, 1);
                }
            }

            this.hashTable = intersection;
        }

        //Enumerator interface methods
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.hashTable)
            {
                yield return item.Key;
            }
        }        
    }
}
