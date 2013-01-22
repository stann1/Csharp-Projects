using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.CompareCharacters
{
    class CompareCharacters
    {
        static void Main(string[] args)
        {
            char[] firstArray = { 'a', 'b', 'c', 'd', 'e' };
            char[] secondArray = { 'a', 'b', 'c', 'd', 'b', 'f'};
            int smallerLength = Math.Min(firstArray.Length, secondArray.Length);
            bool firstArraySmaller = false;
            bool secondArraySmaller = false;

            for (int i = 0; i < smallerLength; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    firstArraySmaller = true;
                    Console.WriteLine("Lexicographically, array A is first");
                    break;
                }
                else if (firstArray[i] > secondArray[i])
                {
                    secondArraySmaller = true;
                    Console.WriteLine("Lexicographically, array B is first");
                    break;
                }
            }

            if (firstArraySmaller == false && secondArraySmaller == false)    //Condition where both arrays have same numbers
            {
                if (firstArray.Length < secondArray.Length)                   //The shorter length determines the winner
                {
                    Console.WriteLine("Lexicographically, array A is first");
                }
                else if (firstArray.Length > secondArray.Length)
                {
                    Console.WriteLine("Lexicographically, array B is first");
                }
                else if (firstArray.Length == secondArray.Length)
                {
                    Console.WriteLine("The arrays are equal");
                }
            }

        }
    }
}
