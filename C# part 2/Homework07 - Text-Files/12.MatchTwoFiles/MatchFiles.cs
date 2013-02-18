using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.MatchTwoFiles
{
    class MatchFiles
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader firstRead = new StreamReader(@"..\..\input1.txt");
                StreamReader secondRead = new StreamReader(@"..\..\input2.txt");
                StreamWriter writer = new StreamWriter(@"..\..\output.txt");

                using (firstRead)
                {
                    string wordsString = firstRead.ReadToEnd();
                    string[] words = wordsString.Split('\r', '\n');        //generates array form all the words

                    using (secondRead)
                    {
                        using (writer)
                        {
                            string line = secondRead.ReadLine();
                            while (line != null)
                            {
                                for (int i = 0; i < words.Length; i++)
                                {
                                    line = Regex.Replace(line, "\\b" + words[i] + "\\b", "");      //each word is replaced

                                }
                                writer.WriteLine(line);
                                line = secondRead.ReadLine();
                            }
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
