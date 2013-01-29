using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13.WordsFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] allWords = File.ReadAllLines(@"..\..\words.txt");
                string testFile = @"..\..\test.txt";
                StreamReader reader = new StreamReader(testFile);
                StreamWriter writer = new StreamWriter(@"..\..\result.txt");

                using (reader)
                {
                    string line = reader.ReadLine();
                    int[] count = new int[allWords.Length];

                    while (line != null)
                    {
                        for (int i = 0; i < allWords.Length; i++)
                        {
                            var regex = Regex.Matches(line, "\\b" + allWords[i] + "\\b");
                            count[i] += regex.Count;
                        }
                        line = reader.ReadLine();
                    }

                    Array.Sort(count, allWords);

                    writer.WriteLine("Word : frequency");
                    for (int i = allWords.Length - 1; i >= 0; i--)
                    {
                        writer.WriteLine("{0} : {1}", allWords[i], count[i]);            //?? File appears empty!
                        Console.WriteLine("{0} : {1}", allWords[i], count[i]);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
