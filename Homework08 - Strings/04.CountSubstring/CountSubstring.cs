using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountSubstring
{
    class CountSubstring
    {
        static void Main(string[] args)
        {
            string text = "We are living in an yellow submarine. We don't have anything else. " +
                          "Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            int subCounter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'i' || text[i] == 'I')
                {
                    string substring = text.Substring(i, 2);
                    substring = substring.ToLower();                  //Converts the substring to lowercase
                    if (substring == "in")
                    {
                        subCounter++;
                    }
                }
            }

            Console.WriteLine(subCounter);
        }
    }
}
