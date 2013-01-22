using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CalculateFactorial
{
    class CalcFactorial
    {
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

            if (sumArray[sumArray.Length - 1] == 0)
            {
                Array.Resize(ref sumArray, sumArray.Length - 1);
            }
            return sumArray;

        }

        static int[] MultiplyArrays(int[] factorialArray, int position)
        {
            int[] dummyArray = { 0 };

            for (int i = 0; i < position; i++)
            {
                dummyArray = SumOfArrays(factorialArray, dummyArray);
            }

            return dummyArray;
        }

        static void Main(string[] args)
        {
            int[] factorialArray = { 1 };

            int n = 100;                     //Number to calculate factorial

            for (int i = 1; i <= n; i++)
            {
                int[] result = MultiplyArrays(factorialArray, i);
                factorialArray = result;
            }

            for (int i = factorialArray.Length - 1; i >= 0; i--)        //Because the array is reversed, it starts from the end
            {
                Console.Write(factorialArray[i]);
            }
            Console.WriteLine();
        }

    }
}
