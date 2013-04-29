using System;
using System.Linq;
using Telerik.ILS.Common;

namespace TestStringExtensionsLibrary
{
    class TestExtensionLib
    {
        static void Main(string[] args)
        {
            string userInput = "some text";

            string hashed = StringExtensions.ToMd5Hash(userInput);
            Console.WriteLine(hashed);

            string output = StringExtensions.ToValidUsername(userInput);
            Console.WriteLine(output);

            string content = StringExtensions.ToContentType("docx");
            Console.WriteLine(content);

            string innerStr = StringExtensions.GetStringBetween("somethingwritteeninbetween", "something", "in");
            Console.WriteLine(innerStr);

            byte[] byteArr = StringExtensions.ToByteArray(userInput);
            foreach (var item in byteArr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
}
