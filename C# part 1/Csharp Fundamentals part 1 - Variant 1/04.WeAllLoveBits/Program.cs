using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WeAllLoveBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];

            for (int count = 0; count < n; count++)
            {
                input[count] = int.Parse(Console.ReadLine());
            }

            for (int count = 0; count < n; count++)
            {
                int[] reverseArray = new int[31];
                int startPosition = 0;
                bool firstBit = false;

                for (int i = 31; i >= 0; i--)
                {
                    int bit = ((1 << i) & input[count]) >> i;
                    if (bit == 1 && firstBit == false)
                    {
                        startPosition = i;
                        firstBit = true;
                    }
                    if (firstBit)
                    {
                        reverseArray[i] = bit;
                    }
                }
                int result = 0;
                for (int i = 0; i <= startPosition; i++)
                {
                    result += (int)Math.Pow(2, startPosition - i) * reverseArray[i];
                }
                Console.WriteLine(result); 
            }
            
        }
    }
}
