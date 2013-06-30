using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ZigZagSequence
{
    //The program generates all possible variations without repetition from the input and counts only those
    //that fulfill the condition a0>a1<a2>a3......
    class Program
    {
        static int n;
        static int k;
        static int[] sequence;
        static bool[] used;
        static int counter = 0;
        static int zigZagCount = 0;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] split = input.Split(' ');

            n = int.Parse(split[0]);
            k = int.Parse(split[1]);
            sequence = new int[k];
            used = new bool[n];

            GenerateVariationsNoRep(0);
            //Console.WriteLine(counter);
            Console.WriteLine(zigZagCount);
        }

        private static void GenerateVariationsNoRep(int index)
        {
            if (index >= k)
            {
                counter++;
                CheckIfSequenceZigZag();
                //Console.WriteLine(string.Join(", ", sequence));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    sequence[index] = i;
                    GenerateVariationsNoRep(index + 1);
                    used[i] = false;
                }
            }
        }

        private static void CheckIfSequenceZigZag()
        {           
            bool isZigZag = true;

            for (int i = 0; i < k - 1; i++)
            {
                if (i % 2 == 0)     //even index
                {
                    if (sequence[i] < sequence[i+1])
                    {
                        isZigZag = false;
                    }
                }
                else
                {
                    if (sequence[i] > sequence[i+1])
                    {
                        isZigZag = false;
                    }
                }
            }

            if (isZigZag)
            {
                zigZagCount++;
            }
        }
    }
}
