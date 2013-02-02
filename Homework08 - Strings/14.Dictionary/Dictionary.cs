using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            string[] dictionary = {".NET – platform for applications from Microsoft",
                                    "CLR – managed execution environment for .NET",
                                    "namespace – hierarchical organization of classes"};
            string search = "namespace";

            for (int i = 0; i < dictionary.Length; i++)
            {
                int found = dictionary[i].IndexOf(search);
                if (found != -1)
                {
                    string sub = dictionary[i].Substring(found + search.Length + 3);
                    Console.WriteLine("word: {0}", search);
                    Console.WriteLine("definition: {0}", sub);
                }
            }

        }
    }
}
