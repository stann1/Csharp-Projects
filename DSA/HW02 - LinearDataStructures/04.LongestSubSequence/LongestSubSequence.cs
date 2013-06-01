using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LongestSubSequence
{
    class LongestSubSequence
    {
        static void Main(string[] args)
        {
            List<int> sequence = new List<int>() { 1, 4, 1, 3, 3, 3, 11, -11, 11, 11 };

            List<int> sub = FindLongestSubSequence(sequence);

            Console.WriteLine("The longest subset sequence:");
            Console.WriteLine(string.Join(", ", sub));
        }

        private static List<int> FindLongestSubSequence(List<int> sequence)
        {
            int len = sequence.Count;           
            int maxCount = 1;
            int bestNum = sequence[0];

            for (int i = 0; i < len - 1; i++)
            {
                int count = 1;
                while (sequence[i] == sequence[i+1])
                {                    
                    count++;
                    i++;

                    if (i == len - 1)
                    {
                        break;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    bestNum = sequence[i];
                }
            }

            List<int> sub = new List<int>();
            for (int i = 0; i < maxCount; i++)
            {
                sub.Add(bestNum);
            }

            return sub;
        }
    }
}
