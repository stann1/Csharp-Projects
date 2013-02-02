using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.ReplaceRepeatingLetters
{
    class ReplaceLetters
    {
        static void Main(string[] args)
        {
            //string input = "aaaaabbcccccccdddddeeeeef mmmmmnnnnnnaaaaaab";
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i < input.Length - 1 && (input[i] >= 'A' && input[i] <= 'z') && input[i] == input[i+1])
                {
                    continue;
                }
                else
                {
                    sb.Append(input[i]);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
