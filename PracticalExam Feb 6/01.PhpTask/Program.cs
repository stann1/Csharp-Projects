using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.PhpTask
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string read = Console.ReadLine();
                if (read.Contains("/*") || read.Contains("//"))
                {
                    continue;
                }
                sb.Append(read);
                if (read == "?>")
                {
                    break;
                }
                
            }

            string text = sb.ToString();

           
            string pattern = @"\$\w*";

            MatchCollection matches = Regex.Matches(text, pattern);
            List<string> result = new List<string>();
            int counter = 0;

            foreach (var item in matches)
            {
                result.Add(item.ToString());
               
            }

            List<string> unique = new List<string>();
            for (int i = 0; i < result.Count; i++)
            {
                if (unique.Contains(result[i]))
                {
                    continue;
                }
                else
                {                   
                    unique.Add(result[i]);
                    counter++;
                }
            }
            
            for (int i = 0; i < unique.Count; i++)
            {
                unique[i] = unique[i].Remove(0, 1);
                
            }

            Console.WriteLine(counter);
            unique.Sort();
            foreach (string item in unique)
            {
                Console.WriteLine(item);
            }     



        }
    }
}
