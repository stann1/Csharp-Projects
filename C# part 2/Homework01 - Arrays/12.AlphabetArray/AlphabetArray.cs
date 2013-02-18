using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.AlphabetArray
{
    class AlphabetArray
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];

            for (int i = 0; i < 26; i++)            
            {
                alphabet[i] = (char)(i + 97);           //the code of 'a' in the asci table is 97
            }

            Console.WriteLine("Enter a word on the next line:");
            string word = Console.ReadLine();

            Console.WriteLine("The index of each letter is the following:");
            Console.Write("{");
            for (int i = 0; i < word.Length; i++)
            {
                int pos = Array.IndexOf(alphabet, word[i]);        //Array.Index searches for the specified value in the array
                if (pos > -1)
                {
                    if (i == word.Length - 1)
                    {
                        Console.Write(pos + "}");
                    }
                    else
                    {
                        Console.Write(pos + ", ");
                    }
                }
                
            }
            Console.WriteLine();
        }
    }
}
