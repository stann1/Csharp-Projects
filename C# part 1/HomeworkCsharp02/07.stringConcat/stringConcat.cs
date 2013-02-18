using System;

class stringConcat
{
    static void Main(string[] args)
    {
        string firstWord = "Hello"; 
        string secondWord = "World";
        object concatWord = string.Concat(firstWord, " ", secondWord);
        string result = Convert.ToString(concatWord);
        Console.WriteLine(result);

    }
}

