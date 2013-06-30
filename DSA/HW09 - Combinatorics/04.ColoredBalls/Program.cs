using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ColoredBalls
{
    class Program
    {
        static int counter = 0;

        //The possible arrangement of selected balls (can be of the same color), where the order does not matter - permutations with repetition
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] balls = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                balls[i] = input[i];
            }

            Array.Sort(balls);
            GeneratePermutationsWithSwaps(balls, 0, balls.Length);
            Console.WriteLine(counter);            
        }

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
