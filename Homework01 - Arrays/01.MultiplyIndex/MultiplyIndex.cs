using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MultiplyIndex
{
    static void Main(string[] args)
    {
        int[] array = new int[20];

        for (int i = 0; i < 20; i++)
        {
            array[i] = i * 5;
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

