using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.QuickSort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            string[] array = { "c", "b", "h", "d", "a", "e", "g", "f" };
            List<string> sortingList = new List<string>();

            for (int i = 0; i < array.Length; i++)
            {
                sortingList.Add(array[i]);
            }

            
            List<string> finalSorted = QuickSortList(sortingList);

            Console.WriteLine("The final sorted array is:");
            foreach (var element in finalSorted)                    //Prints the result
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();
        }

        static List<string> QuickSortList(List<string> sorted)     //Sorts the list by dividing in two parts
        {
            if (sorted.Count <= 1)
            {
                return sorted;
            }

            List<string> left = new List<string>();
            List<string> right = new List<string>();
            string middleElement = sorted[sorted.Count / 2];

            for (int i = 0; i < sorted.Count; i++)
            {
                if (i != sorted.Count / 2)
                {
                    if (sorted[i].CompareTo(middleElement) < 0)
                    {
                        left.Add(sorted[i]);
                    }
                    else if (sorted[i].CompareTo(middleElement) > 0)
                    {
                        right.Add(sorted[i]);
                    }
                }
                
            }

            return Concatenate(QuickSortList(left), middleElement, QuickSortList(right));   //Recursive part - each list is sorted again
        }

        private static List<string> Concatenate(List<string> left, string middle, List<string> right)   //Concatenation for the final result
        {
            List<string> result = new List<string>();

            for (int i = 0; i < left.Count; i++)
			{
                result.Add(left[i]);
			}

            result.Add(middle);

            for (int i = 0; i < right.Count; i++)
            {
                result.Add(right[i]);
            }

            return result;
        }

    }
}
