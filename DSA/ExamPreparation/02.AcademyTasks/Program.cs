using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AcademyTasks
{
    class Program
    {
        static int[] problems;        
        static int variety;        

        static void Main(string[] args)
        {
            string[] pleasentness = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            problems = new int[pleasentness.Length];
            for (int i = 0; i < pleasentness.Length; i++)
            {
                problems[i] = int.Parse(pleasentness[i]);
            }

            variety = int.Parse(Console.ReadLine());
            int bestOutcome = problems.Length;

            for (int i = 0; i < problems.Length; i++)
            {
                for (int j = i + 1; j  < problems.Length; j ++)
                {
                    int diff = Math.Abs(problems[i] - problems[j]);
                    if (diff < variety)
                    {
                        continue;
                    }

                    //if the condition is met, we check the needed steps to finish the task
                    //i.e. if j=3 satisfies the condition, i should be at least on position = 1 to close the gap
                    int act = (i + 3) / 2;              //i moves with average 1.5 steps (1 or 2 positions)
                    int gap = (j - i);
                    act += (gap + 1) / 2;
                    bestOutcome = Math.Min(act, bestOutcome);
                }
                
            }

            Console.WriteLine(bestOutcome);
           
        }

        
    }
}
