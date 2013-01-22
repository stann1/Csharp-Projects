using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_12.AddPolynomials
{
    class AddPolynom
    {
        static int[] SumOfArrays(int[] arrayA, int[] arrayB, bool substraction)
        {
            int lengthA = arrayA.Length;
            int lengthB = arrayB.Length;
            if (lengthA < lengthB)
            {
                return SumOfArrays(arrayB, arrayA, substraction);         //To ensure that the first array is always the bigger
            }
            int[] resultArray = new int[lengthA];

            for (int i = 0; i < lengthA; i++)
            {
                if (i >= lengthB)
                {
                    resultArray[i] = arrayA[i];
                }
                else
                {
                    if (substraction)
                    {
                        resultArray[i] = arrayA[i] - arrayB[i];
                    }
                    else
                    {
                        resultArray[i] = arrayA[i] + arrayB[i];
                    }

                }
            }

            return resultArray;
        }


        static int[] MultiplicationOfArrays(int[] arrayA, int[] arrayB)
        {
            int[] multipliedArray = new int[arrayA.Length + arrayB.Length];

            for (int i = 0; i < arrayA.Length; i++)
            {
                for (int j = 0; j < arrayB.Length; j++)
                {
                    int position = i + j;
                    multipliedArray[position] += arrayA[i] * arrayB[j];
                }
            }
            return multipliedArray;
        }


        static void PrintArray(int[] sumArray)
        {
            for (int i = sumArray.Length - 1; i >= 0; i--)
            {
                if (sumArray[i] == 0)
                {
                    continue;
                }

                if (i == 0)
                {
                    Console.Write(sumArray[i]);
                }
                else if (i == 1)
                {
                    Console.Write(sumArray[i] + "x + ");
                }
                else
                {
                    Console.Write(sumArray[i] + "x^" + i + " + ");
                }
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            int[] arrayA = { 5, 0, 1 };                        //coefficient arrays for the two polynomials
            int[] arrayB = { 2, 1, 4, 6 };
            bool substraction = false;

            int[] sumArray = SumOfArrays(arrayA, arrayB, substraction);      //result for addition or substraction
            PrintArray(sumArray);

            int[] multiplyArray = MultiplicationOfArrays(arrayA, arrayB);    //result for multiplication
            PrintArray(multiplyArray);
        }
    }
}
