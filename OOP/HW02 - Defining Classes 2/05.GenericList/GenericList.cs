using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GenericListOperations
{
    public class GenericList<T>
    {
        public T[] storageList;
        private int count;
        private const int capacity = 3;

        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        //Constructor
        public GenericList()
        {
            this.storageList = new T[capacity];
        }

        //Methods
        public void AddElement(T element)
        {
            if (count >= storageList.Length)
            {
                storageList = AutoGrow(storageList);                
            }
            storageList[count] = element;
            count++;
        }

        public T AccessAtIndex(int index)
        {
            if (index >= count)
            {
                throw new ArgumentOutOfRangeException("The index provided is outside the array");
            }

            return storageList[index];
        }

        public void RemoveAtIndex(int index)
        {
            if (index >= count)
            {
                throw new ArgumentOutOfRangeException("The index provided is outside the array");
            }

            T[] newArray = new T[count - 1];

            for (int i = 0, j = 0; i < newArray.Length; i++, j++)
            {
                if (i == index)
                {
                    j++;
                }

                newArray[i] = storageList[j];
            }

            storageList = newArray;
            count--;            
        }

        public void InsertElementAtPosition(T element, int index)
        {
            T[] newArray = new T[storageList.Length];
            if (index > storageList.Length)
            {
                throw new ArgumentOutOfRangeException("The index provided is outside the array");
            }
            if (count == storageList.Length)
            {
                newArray = new T[storageList.Length * 2];                  //autogrow functionality
            }          
            

            for (int i = 0, j = 0; i < newArray.Length; i++, j++)
            {
                if (i == index)
                {
                    newArray[i] = element;
                    j--;
                    continue;
                }
                if (j == storageList.Length)
                {
                    break;
                }

                newArray[i] = storageList[j];
            }

            storageList = newArray;
            count++;            
        }

        public void Clear()
        {
            storageList = new T[count];
        }

        public void FindElement(T element)
        {
            bool found = false;
            for (int i = 0; i < storageList.Length; i++)
            {
                if (storageList[i].Equals(element))
                {
                    Console.WriteLine("{0} is found at index: {1}", element, i);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("The specified element was not found");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in storageList)
            {
                sb.AppendFormat("{0} ", item);
            }
            return sb.ToString();
        }

        public T[] AutoGrow(T[] fullList)                      //task 6
        {
            T[] doubledList = new T[fullList.Length * 2];
            for (int i = 0; i < fullList.Length; i++)
            {
                doubledList[i] = fullList[i];
            }

            return doubledList;
        }

        public T Min()                                              //task 7
        {
            if (storageList.Length == 0)
            {
                throw new ArgumentException("The collection contains no elements");
            }
            if (this.storageList[0] is IComparable<T>)
            {
                T min = storageList[0];

                for (int i = 1; i < storageList.Length; i++)
                {
                    if ((dynamic)storageList[i] < min)
                    {
                        min = (dynamic)storageList[i];
                    }
                }
                return min;
            }
            else
            {
                throw new ArgumentException("The provided list does not contain IComparable elements");
            }
        }

        public T Max()                                              //task 7
        {
            if (storageList.Length == 0)
            {
                throw new ArgumentException("The collection contains no elements");
            }
            if (this.storageList[0] is IComparable<T>)
            {
                T max = storageList[0];

                for (int i = 1; i < storageList.Length; i++)
                {
                    if ((dynamic)storageList[i] > max)
                    {
                        max = (dynamic)storageList[i];
                    }
                }
                return max;
            }
            else
            {
                throw new ArgumentException("The provided list does not contain IComparable elements");
            }
        }
    }
}
