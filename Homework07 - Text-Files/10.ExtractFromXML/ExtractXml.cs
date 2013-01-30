using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExtractFromXML
{
    class ExtractXml
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\input.xml");

            using (reader)
            {
                int readNextChar = reader.Read();
                string word = "";
                bool start = false;

                while (readNextChar != -1)
                {
                    if (readNextChar == '>')
                    {
                        start = true;
                    }
                    if (start)
                    {
                        readNextChar = reader.Read();
                        while (readNextChar!= '<' && readNextChar != -1)
                        {
                            if (readNextChar != '\r' && readNextChar != '\n')         //This will trim new lines
                            {
                                word += (char)readNextChar;
                            }                            
                            readNextChar = reader.Read();
                        }
                        if(word != "") Console.WriteLine(word.Trim());         
                        word = "";
                        start = false;
                    }
                    readNextChar = reader.Read();
                }
            }
        }
    }
}
