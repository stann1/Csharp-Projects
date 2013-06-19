using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ImplementHashTable
{
    public class CustomHashTable<K, T> : IEnumerable<KeyValuePair<K,T>>
    {
        private LinkedList<KeyValuePair<K, T>>[] keyValueList;
        private int currentCount;
        private int capacity;

        public CustomHashTable(int capacity = 16)
        {
            this.Capacity = capacity;
            this.keyValueList = new LinkedList<KeyValuePair<K, T>>[this.capacity];
            this.CurrentCount = 0;            
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The capacity cannot be negative!");
                }
                this.capacity = value;
            }
        }

        public LinkedList<KeyValuePair<K, T>>[] KeyValueList
        {
            get
            {
                return this.keyValueList;
            }
            set
            {
                this.keyValueList = value;
            }
        }

        public int CurrentCount
        {
            get
            {
                return this.currentCount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The elements count cannot be negative!");
                }
                this.currentCount = value;
            }
        }

        public T this[K key]
        {
            get { return this.Find(key);}
            set { this.SetValue(key, value); }
        }  

        //public methods
        public void Add(K key, T value)
        {
            if (key == null)
            {
                throw new ArgumentNullException("The key cannot be null!");
            }
            if (this.CurrentCount >= this.capacity * 0.75 )
            {
                ExpandTable();
            }
            
            var index = key.GetHashCode() % this.capacity;

            if (this.KeyValueList[index] == null)
            {
                this.KeyValueList[index] = new LinkedList<KeyValuePair<K, T>>();
            }

            var nextPair = this.KeyValueList[index].First;
            while (nextPair != null)
            {
                if (nextPair.Value.Key.Equals(key))
                {
                    throw new ArgumentException("This key already exists in the table!");
                }
                nextPair = nextPair.Next;
            }
            this.KeyValueList[index].AddLast(new KeyValuePair<K, T>(key, value));
            this.CurrentCount++;
        }

        public T Find(K key)
        {
            if (key == null)
            {
                throw new ArgumentNullException("The key cannot be null!");
            }

            var index = key.GetHashCode() % this.capacity;

            if (this.KeyValueList[index] == null)
            {
                throw new NullReferenceException("The key does not exist!");
            }

            var nextPair = this.KeyValueList[index].First;
            while (nextPair != null)
            {
                if (nextPair.Value.Key.Equals(key))
                {
                    return nextPair.Value.Value;
                }
                nextPair = nextPair.Next;
            }
            throw new ArgumentException("The key does not exist!");
        }

        public void Remove(K key)
        {
            if (key == null)
            {
                throw new ArgumentNullException("The key cannot be null!");
            }

            var index = key.GetHashCode() % this.capacity;

            if (this.KeyValueList[index] == null)
            {
                throw new NullReferenceException("The key does not exist!");
            }

            foreach (var pair in this.KeyValueList[index])
            {
                if (pair.Key.Equals(key))
                {
                    this.KeyValueList[index].Remove(pair);
                    this.CurrentCount--;
                    return;
                }
            }
            throw new ArgumentException("The key does not exist!");
        }

        public bool Contains(K key)
        {
            if (key == null)
            {
                throw new ArgumentNullException("The key cannot be null!");
            }

            var index = key.GetHashCode() % this.capacity;

            if (this.KeyValueList[index] == null)
            {
                return false;
            }

            var nextPair = this.KeyValueList[index].First;
            while (nextPair != null)
            {
                if (nextPair.Value.Key.Equals(key))
                {
                    return true;
                }
                nextPair = nextPair.Next;
            }
            return false;
        }

        public void Clear()
        {
            this.KeyValueList = new LinkedList<KeyValuePair<K, T>>[this.capacity];
            this.CurrentCount = 0;
        }

        //private methods
        private void ExpandTable()
        {
            LinkedList<KeyValuePair<K, T>>[] expanded = new LinkedList<KeyValuePair<K, T>>[this.capacity * 2];
            Array.Copy(this.KeyValueList, expanded, this.capacity);
            this.KeyValueList = expanded;
            this.Capacity *= 2; 
        }        

        private void SetValue(K key, T value)
        {
            if (key == null)
            {
                throw new ArgumentNullException("The key cannot be null!");
            }

            var index = key.GetHashCode() % this.capacity;

            if (this.KeyValueList[index] == null)
            {
                this.Add(key, value);
                return;
            }

            foreach (var pair in this.KeyValueList[index])
            {
                if (pair.Key.Equals(key))
                {
                    var newPair = new KeyValuePair<K, T>(key, value);
                    this.KeyValueList[index].Remove(pair);
                    this.KeyValueList[index].AddFirst(newPair);
                    return;
                }
            }
            throw new ArgumentException("The key does not exist!");
        }

        //IEnumerable interface methods
        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            for (int i = 0; i < this.KeyValueList.Length; i++)
            {
                if (this.KeyValueList[i] != null)
                {
                    var next = this.KeyValueList[i].First;
                    while (next != null)
                    {
                        yield return next.Value;
                        next = next.Next;
                    }
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
