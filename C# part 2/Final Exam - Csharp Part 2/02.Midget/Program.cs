using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Midget
{
    class Program
    {
        static short[] FillValley(short[] valley, string[] valleyString)
        {
            for (int i = 0; i < valley.Length; i++)
            {
                valley[i] = short.Parse(valleyString[i].Trim());                
            }
            
            return valley;
        }

        static short[] FillPatterns(short[][] patterns, string input)
        {
            string[] patternString = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            short[] newPattern = new short[patternString.Length];

            for (int i = 0; i < newPattern.Length; i++)
            {
                newPattern[i] = short.Parse(patternString[i].Trim());                
            }
            
            return newPattern;
        }

        static void Main(string[] args)
        {
            string inputValley = Console.ReadLine();            

            string[] valleyString = inputValley.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);  //generate valley
            short[] valley = new short[valleyString.Length];
            valley = FillValley(valley, valleyString);                 //fill-in valley

            short m = short.Parse(Console.ReadLine());
            short[][] patterns = new short[m][]; 
            for (int i = 0; i < m; i++)                         //fill-in patterns
            {
                string input = Console.ReadLine();
                patterns[i] = FillPatterns(patterns, input);
            }

            //==================================Solve the task=================================
            int bestSum = int.MinValue;            

            for (int i = 0; i < m; i++)
            {
                bool[] visited = new bool[valley.Length];
                short[] nextpattern = patterns[i];
                int currSum = 0;
                short valIndex = 0;
                short patIndex = 0;

                while ((valIndex >= 0 && valIndex < valley.Length) && visited[valIndex] == false)
                {
                    currSum += valley[valIndex];
                    visited[valIndex] = true;
                    valIndex += nextpattern[patIndex];
                    patIndex++;
                    if (patIndex >= nextpattern.Length)
                    {
                        patIndex = 0;
                    }
                }

                if (currSum > bestSum)
                {
                    bestSum = currSum;
                }
            }

            Console.WriteLine(bestSum);
            
        }

        

        
    }
}
