using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13.WordsFrequency
{
    class WordsFrequency
    {
        static void Main(string[] args)
        {
            try
            {
                string[] allWords = File.ReadAllLines(@"..\..\words.txt");
                StreamReader reader = new StreamReader(@"..\..\test.txt");
                StreamWriter writer = new StreamWriter(@"..\..\result.txt");

                using (reader)
                {
                    string line = reader.ReadLine();
                    int[] count = new int[allWords.Length];

                    while (line != null)
                    {
                        for (int i = 0; i < allWords.Length; i++)
                        {
                            var regex = Regex.Matches(line, "\\b" + allWords[i] + "\\b");      //All matches are stored in list-type var, we need the count only
                            count[i] += regex.Count;
                        }
                        line = reader.ReadLine();
                    }

                    Array.Sort(count, allWords);                       //sorts ascending (will be reversed at the end)

                    using (writer)
                    {
                        writer.WriteLine("Word : frequency");
                        for (int i = allWords.Length - 1; i >= 0; i--)
                        {
                            writer.WriteLine("{0} : {1}", allWords[i], count[i]);            

                        }
                    }
                   
                }
            }
            catch (FileNotFoundException ff)
            {
                Console.WriteLine(ff.Message);
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }            
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine(uae.Message);
            }
        }
    }
}
