using System;

class stringQuote
{
    static void Main(string[] args)
    {
        string methodOne = @"The ""use"" of quotations causes difficulties";
        Console.WriteLine(methodOne);
        string methodTwo = "The \"use\" of quotations causes difficulties";
        Console.WriteLine(methodTwo);
    }
}
