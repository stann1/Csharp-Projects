using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MessagesInABottle
{
    class Program
    {
        static string secretCode;
        static string cypher;
        static Dictionary<char, string> encodingList;
        static char[] currentSollution;
        static List<string> sollutions;

        static void Main(string[] args)
        {
            secretCode = Console.ReadLine();
            cypher = Console.ReadLine();
            encodingList = new Dictionary<char, string>();
            currentSollution = new char[26];
            sollutions = new List<string>();

            FillInEncodingList();

            GenerateSollutions(0, 0);

            Console.WriteLine(sollutions.Count);
            sollutions.Sort();
            foreach (var sol in sollutions)
            {
                Console.WriteLine(sol);
            }
        }
  
        private static void FillInEncodingList()
        {            
            int startLetterIndex = 0;
            char startLetter = cypher[0];
            int length = 0;
            string subSequence = "";

            for (int i = 1; i < cypher.Length; i++)
            {
                char symbol = cypher[i];

                if (i == cypher.Length - 1)
                {
                    length++;
                }
                                  
                if (symbol - 0 > 64 || i == cypher.Length - 1)
                {
                    subSequence = cypher.Substring(startLetterIndex + 1, length);
                    encodingList.Add(startLetter, subSequence);

                    startLetterIndex = i;
                    startLetter = cypher[i];
                    length = 0;
                }
                else
                {
                    length++;
                }
            }
        }

        private static void GenerateSollutions(int index, int wordIndex)
        {
            if (index == secretCode.Length)
            {
                AddCurrentSollution(currentSollution);
                return;
            }
            if (index > secretCode.Length)
            {
                return;                
            }

            foreach (var item in encodingList)
            {
                int letterEncodingLength = item.Value.Length;

                if (letterEncodingLength + index <= secretCode.Length && 
                    item.Value == secretCode.Substring(index, letterEncodingLength))
                {
                    currentSollution[wordIndex] = item.Key;
                    GenerateSollutions(index + item.Value.Length, wordIndex + 1);
                    currentSollution[wordIndex] = '\0';
                }
            }
        }

        private static void AddCurrentSollution(char[] currentSollution)
        {
            StringBuilder variation = new StringBuilder();
            foreach (var letter in currentSollution)
            {
                if (letter >= 'A' && letter <= 'Z')
                {
                    variation.Append(letter);
                }
            }

            sollutions.Add(variation.ToString());
        }
    }
}
