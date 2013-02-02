using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Tubes
{
    class Program
    {
        static void Main(string[] args)
        {
            int tubes = int.Parse(Console.ReadLine());
            int friends = int.Parse(Console.ReadLine());

            int[] sizes = new int[tubes];
            long totalSize = 0;

            for (int i = 0; i < tubes; i++)
            {
                sizes[i] = int.Parse(Console.ReadLine());
                totalSize += sizes[i];
            }

            long maxSize = totalSize / friends;
            long minSize = 0;
            long currCount = 0;


            if (maxSize != 0)
            {
                long middle = (maxSize + minSize) / 2;

                while (minSize < maxSize)
                {
                    currCount = 0;
                    middle = (maxSize + minSize) / 2;
                    if (middle == 0)
                    {
                        minSize = 1;
                        break;
                    }

                    for (int i = 0; i < tubes; i++)
                    {
                        currCount += sizes[i] / middle;
                    }
                    if (currCount < friends)
                    {
                        maxSize = middle;
                    }
                    else
                    {
                        minSize = middle + 1;
                    }
                }
                //needs answer correction
            }
            else
            {
                Console.WriteLine(-1);
            }

            while (minSize >= 1)
            {
                currCount = 0;
                foreach (var tube in sizes)
                {
                    currCount += tube / minSize;
                }
                if (currCount >= friends)
                {
                    break;
                }
                minSize--;
            }

            Console.WriteLine(minSize);

        }
    }
}
