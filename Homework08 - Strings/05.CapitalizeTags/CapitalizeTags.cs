using System;
using System.Linq;
using System.Text;

namespace _05.CapitalizeTags
{
    class CapitalizeTags
    {
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            StringBuilder sb = new StringBuilder();
            int tagCount = 0;
            

            for (int i = 0; i < text.Length; i++)
            {                
                if (text[i] == '<')
                {                    
                    while (text[i] != '>')
                    {
                        i++;
                    }
                    tagCount++;
                    continue;                         //after finding '>' jumps to next iteration
                }
                if (tagCount % 2 == 1)
                {
                    sb.Append(Char.ToUpper(text[i]));        //Using the Char class to capitalize the letters.
                }
                else
                {
                    sb.Append(text[i]);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
