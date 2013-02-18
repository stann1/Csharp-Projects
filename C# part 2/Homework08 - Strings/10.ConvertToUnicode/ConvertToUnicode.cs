using System;
using System.Linq;
using System.Text;

namespace _10.ConvertToUnicode
{
    class ConvertToUnicode
    {
        static void Main(string[] args)
        {
            string input = "Hello!";

            for (int i = 0; i < input.Length; i++)
            {
                char test = input[i];
                string result = string.Format("\\u{0:X4}", (int)test);

                Console.Write(result);
            }
            Console.WriteLine();
            
        }
    }
}
