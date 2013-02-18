using System;
using System.Text;

class printTriangle
{
    static void Main(string[] args)
    {
        char element = '\u00A9';
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine(" " + " " + " " + element);
        Console.WriteLine(" " + " " + element + " " + element);
        Console.WriteLine(" " + element + " " + " " + " " + element);
        Console.WriteLine(element + " " + element + " " + element + " " + element);
    }
}

