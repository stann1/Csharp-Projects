using System;


namespace _05.Pillars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 8];
            int bitCounter = 0;
            bool noLine = true;
            int lineSplit = 0;
            int bitsum = 0;

            for (int row = 0; row < 8; row++)
            {
                int n = int.Parse(Console.ReadLine());
                for (int column = 0; column < 8; column++)
                {
                    matrix[row, column] = ((n >> column) & 1);
                    if (matrix[row, column] == 1)
                    {
                        bitCounter++;
                    }
                }
            }
            
            if (bitCounter < 2)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int column = 6; column > 1; column--)
                {
                    int rightBits = 0;
                    int leftBits = 0;
                    for (int i = 0; i < column; i++)            //this calculates the right side
                    {
                        for (int row = 0; row < 8; row++)
                        {
                            rightBits += matrix[row, i]; 
                        } 
                    }

                    for (int i = column + 1; i < 8; i++)        //this calculates the left side
                    {
                        for (int row = 0; row < 8; row++)
                        {
                            leftBits += matrix[row, i]; 
                        } 
                    }

                    if (leftBits == rightBits)
                    {
                        lineSplit = column;
                        bitsum = leftBits;
                        noLine = false;
                        break;
                    }
                }

                if ((noLine == true) || bitsum == 0)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    Console.WriteLine(lineSplit);
                    Console.WriteLine(bitsum);
                }
            }
                

           
        }
    }
}
