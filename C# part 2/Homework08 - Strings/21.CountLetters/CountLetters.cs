using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.CountLetters
{
    class CountLetters
    {
        static void Main(string[] args)
        {
            //string text = "some random text appears";

            Console.WriteLine("Enter some text:");
            string text = Console.ReadLine();

            int[] letterCount = new int['z'+1];
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                int letterNum = (int)letter;
                if (letterNum < 91)
                {
                    letterNum = letterNum + 26;
                }
                letterCount[letterNum]++;
            }

            Console.WriteLine("Letters : count");
            for (int i = 91; i < letterCount.Length; i++)
            {
                if (letterCount[i] != 0)
                {
                    Console.Write((char)i + ": ");
                    Console.WriteLine(letterCount[i]);
                }
            }
        }
    }
}
