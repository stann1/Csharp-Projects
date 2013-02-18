using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] array = {1, 4, 4, 6, 9, 14, 17};
            int searchNumber = 4;
            int maxIndex = array.Length-1;
            int minIndex = 0;
            int middleIndex = 0;
            bool noNumber = true;
            

            while (maxIndex >= minIndex)
            {
                middleIndex = (maxIndex + minIndex) / 2;        //This takes the average of Min Max   
                

                if (array[middleIndex] > searchNumber)          //Max-1 if the searched number is lower than the average, or Min+1 if higher
                {                                               
                    maxIndex = middleIndex - 1;
                }
                else if (array[middleIndex] < searchNumber)
                {
                    minIndex = middleIndex + 1;
                }
                else if (array[middleIndex] == searchNumber)
                {
                    noNumber = false;
                    Console.WriteLine("The index of the number {0} in the array is: {1}", searchNumber, middleIndex);
                    break;
                }

                
            }
            if (noNumber)
            {
                Console.WriteLine("Number not found!");
            }
        }
    }
}
