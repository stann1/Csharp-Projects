using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ProvadiaNumbers
{
    class Program
    {
        static string[] baseChars = new string[256];

        static void ConvertBase10toY(ulong inputNumber, ulong outputBase)
        {            
            if (inputNumber == 0)
            {
                Console.WriteLine("A");
                return;
            }

            List<ulong> result = new List<ulong>();

            while (inputNumber > 0)            
            {                
                result.Add(inputNumber % outputBase);
                inputNumber /= outputBase;
            }
            
            for (int i = result.Count - 1; i >= 0; i--)
            {
                Console.Write(baseChars[result[i]]);
            }
            Console.WriteLine();
           
            
        }

        static void GenerateBaseCharacters(ulong outputBase)              //characters for base 256
        {            
            int nextstep = 0;
            for (int i = 0; i < 256; i++)
            {
                int nextLetter = i + 65;
                string character = "";
                string prefix = "";
                if (i > 25 && i % 26 == 0)
                {
                    nextstep++;                    
                }

                nextLetter = nextLetter - 26*nextstep;
                if (i < 26)
                {
                    character = ((char)nextLetter).ToString();
                }
                else
                {
                    prefix = ((char)(96 + nextstep)).ToString();
                    character = prefix + ((char)nextLetter).ToString(); 
                }
                           

                
                baseChars[i] = character;
            }
            
        }

        static void Main(string[] args)
        {
            ulong inputNumber = ulong.Parse(Console.ReadLine());
            ulong outputBase = 256;

            GenerateBaseCharacters(outputBase);

            ConvertBase10toY(inputNumber, outputBase);
        }

        
    }
}
