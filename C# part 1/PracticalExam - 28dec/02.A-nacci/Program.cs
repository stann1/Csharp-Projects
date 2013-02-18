using System;


namespace _02.A_nacci
{
    class Program
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());
            int anacciInput1 = (int)input1 - 64;
            int anacciInput2 = (int)input2 - 64;
            int size = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxSize = size;
            string seperator = " ";


            for (int i = 1; i < size*2; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine((char)(anacciInput1 + 64));
                }
                if (i == 2)
                {
                    Console.Write((char)(anacciInput2 + 64));
                }
                if (i > 2)
                {
                    sum = anacciInput1 + anacciInput2;
                    anacciInput1 = anacciInput2;
                    anacciInput2 = sum;

                    if (anacciInput2 > 26)
                    {
                        anacciInput2 = anacciInput2 % 26;
                    }

                    if (i % 2 != 0)
                    {
                        Console.WriteLine((char)(anacciInput2 + 64));
                    }
                    else
                    {
                        Console.Write((char)(anacciInput2 + 64) + seperator);
                        seperator += " ";
                    } 
                }

            }
            

        }
    }
}
