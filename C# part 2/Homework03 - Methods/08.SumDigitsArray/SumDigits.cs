using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumDigitsArray
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 4, 1, 8, 5, 2, 1 };
            int[] secondArray = { 8, 6, 1, 2, 7, 6, 4, 8 };

            int[] sumArray = SumOfArrays(firstArray, secondArray);
            for (int i = sumArray.Length - 1; i >= 0; i--)
            {
                if (i == sumArray.Length - 1 && sumArray[i] == 0)        //If the last element was 0, it will not be printed
                {
                    continue;
                }
                Console.Write(sumArray[i]);
            }
            Console.WriteLine();
        }

        static int[] SumOfArrays(int[] firstArray, int[] secondArray)
        {
            bool firstArrayShorter = (firstArray.Length < secondArray.Length);
            int minLength = 0;
            int maxLength = 0;
            if (firstArrayShorter)
            {
                minLength = firstArray.Length;
                maxLength = secondArray.Length;
            }
            else
            {
                minLength = secondArray.Length;
                maxLength = firstArray.Length;
            }

            int[] sumArray = new int[maxLength + 1];         //size is 1 more, because if the 2 sizes are equal, the last digits may sum to more than 10                              
            bool largerThanTen = false;

            for (int i = 0; i < sumArray.Length; i++)
            {
                int tempSum = 0;
                if (i < minLength)                      // First part - sums both arrays
                {
                    tempSum = firstArray[i] + secondArray[i];
                }
                else if (i >= minLength && i < sumArray.Length - 1)         //Second part - sums only the longer array
                {
                    if (firstArrayShorter)
                    {
                        tempSum += secondArray[i];
                    }
                    else
                    {
                        tempSum += firstArray[i];
                    }
                }

                if (largerThanTen)                           //Adds 1 if the previous sum was > 10
                {
                    tempSum += 1;
                }

                if (tempSum > 9)
                {
                    largerThanTen = true;
                    sumArray[i] = tempSum % 10;
                }
                else
                {
                    largerThanTen = false;
                    sumArray[i] = tempSum;
                }
            }

            return sumArray;

        }
    }
}
