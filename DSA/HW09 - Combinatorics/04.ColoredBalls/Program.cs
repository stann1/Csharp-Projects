using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.ColoredBalls
{
    class Program
    {
        static BigInteger counter = 0;

        //The possible arrangement of selected balls (can be of the same color), where the order does not matter - permutations with repetition
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] balls = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                balls[i] = input[i];
            }

            //Array.Sort(balls);
            //GeneratePermutationsWithSwaps(balls, 0, balls.Length);
            counter = CountSequencesOverflow(balls);
            Console.WriteLine(counter);            
        }

        /// <summary>
        /// Uses direct statistical formula to calculate the total permutations, can be slow for large, diverse collection
        /// </summary>
        private static BigInteger CountSequencesOverflow(char[] balls)
        {
            // We calculate directly the formula n! / (c1! * c2! * ... ck!)
            // where c1, c2, .. ck are the number of the balls fo each color

            int n = balls.Length;
            BigInteger result = Factorial(n);

            int[] ballCounts = new int['Z' + 1];
            foreach (var ball in balls)
            {
                ballCounts[ball]++;
            }
            for (int i = 'A'; i <= 'Z'; i++)
            {
                int ballsOfCertainColor = ballCounts[i];
                BigInteger factorial = Factorial(ballsOfCertainColor);
                result /= factorial;
            }

            return result;
        }

        private static BigInteger Factorial(int n)
        {
            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        /// <summary>
        /// Generates all possible permutations, however, it is is somehow slow
        /// </summary>
        private static void GeneratePermutationsWithSwaps(char[] balls, int start, int size)
        {
            counter++;

            if (start < size)
            {
                for (int left = size - 2; left >= start; left--)
                {
                    for (int right = left + 1; right < size; right++)
                    {
                        if (balls[left] != balls[right])
                        {
                            Swap(ref balls[left], ref balls[right]);
                            GeneratePermutationsWithSwaps(balls, left + 1, size);
                        }
                    }

                    var swapValue = balls[left];
                    for (int i = left; i < size - 1; i++)
                    {
                        balls[i] = balls[i + 1];
                    }
                    balls[size - 1] = swapValue;
                }
            }            
        }
  
        private static void Swap(ref char first, ref char second)
        {
            char temp = first;
            first = second;
            second = temp;
        }

        private static void PrintPerm(char[] balls)
        {
            foreach (var ball in balls)
            {
                Console.Write(ball + " ");
            }
            Console.WriteLine();
        }
    }
}
