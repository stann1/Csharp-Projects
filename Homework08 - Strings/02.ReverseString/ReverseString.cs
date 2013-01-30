using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string myString = "bicycle";
            int stringLenght = myString.Length;
            string reversed = "";

            for (int i = 0; i < stringLenght; i++)
            {
                reversed += myString[stringLenght - i - 1];
            }

            Console.WriteLine(reversed);
           
        }
    }
}
