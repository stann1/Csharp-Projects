using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "ha", "haha", "hihihi", "hoh", "hohohohohohoh" };

            SortBySize(stringArray);
        }

        static void SortBySize(string[] stringArray)
        {
            int n = stringArray.Length;
            int[] sizes = new int[n];              //This will hold the size of each string

            for (int i = 0; i < n; i++)
            {
                sizes[i] = stringArray[i].Length;
            }

            Array.Sort(sizes, stringArray);       //Sorts the second array, according to the "keys" in the first (ascending)

            foreach (var element in stringArray)
            {
                Console.WriteLine(element);
            }


        }
    }
}
