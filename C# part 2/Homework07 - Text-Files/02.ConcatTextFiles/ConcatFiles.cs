using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.ConcatTextFiles
{
    class ConcatFiles
    {
        static void Main(string[] args)
        {
            StreamReader firstStream = new StreamReader("sample1.txt", Encoding.GetEncoding("windows-1251"));
            StreamReader secondStream = new StreamReader("sample2.txt", Encoding.GetEncoding("windows-1251"));
            StreamWriter output = new StreamWriter("output.txt", true, Encoding.GetEncoding("windows-1251"));

            using (output)
            {

                using (firstStream)
                {                    
                    output.Write(firstStream.ReadToEnd());
                }

                using (secondStream)
                {
                    output.Write(secondStream.ReadToEnd());
                } 
            }
        }
    }
}
