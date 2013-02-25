using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GenericListOperations
{
    public class GenericList<T>
    {
        public T[] storageList {get;set;}
        private int count;

        public int Count
        {
            get { return this.count; }
        }

        //Constructor
        public GenericList(int capacity)
        {
            this.storageList = new T[capacity];
        }

        //Methods
        public void AddElement(T element)
        {
            if (count >= storageList.Length)
            {
                throw new ArgumentOutOfRangeException("The length of the storage array has been exceeded!");
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
            if (index > count)
            {
                throw new ArgumentOutOfRangeException("The index provided is outside the array");
            }

            T[] newArray = new T[count + 1];

            for (int i = 0, j = 0; i < newArray.Length; i++, j++)
            {
                if (i == index)
                {
                    newArray[i] = element;
                    j--;
                    continue;
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

    }
}
