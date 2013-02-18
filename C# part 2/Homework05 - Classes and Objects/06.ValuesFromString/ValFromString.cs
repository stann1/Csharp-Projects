using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.ValuesFromString
{
    class ValFromString
    {
        static void Main(string[] args)
        {
            string stringNum = "43 68 9 23 318";
            int breakIndex = -1;
            int sum = 0;
            
            for (int i = 0; i < stringNum.Length; i++)
            {
                if ((int)stringNum[i] == 32 || i == stringNum.Length-1)            //32 is the asci code for empty space
                {
                    string tempNum = "0";
                    if (i == stringNum.Length-1 && stringNum[i] != ' ')
                    {
                         tempNum = stringNum.Substring(breakIndex + 1, i - (breakIndex));    //length is 1 more, to include the last char
                    }
                    else
                    {
                        tempNum = stringNum.Substring(breakIndex + 1, i - (breakIndex + 1));
                    }
                    
                    sum += int.Parse(tempNum);
                    breakIndex = i;
                }

            }

            Console.WriteLine("The string sums to:");
            Console.WriteLine(sum);
        }
    }
}
