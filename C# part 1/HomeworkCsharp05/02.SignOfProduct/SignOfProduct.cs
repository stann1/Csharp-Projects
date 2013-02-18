using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfProduct
{
    class SignOfProduct
    {
        static void Main(string[] args)
        {
            float a = 4.9f;
            float b = 2f;
            float c = 1f;

            Console.WriteLine("The numbers are {0} / {1} / {2}", a, b, c);
            if (a >= 0) 
            {
                if ((b >= 0) ^ (c >= 0))
                {
                    Console.WriteLine("The sign of the product is \"-\"");
                }
                else
                {
                    Console.WriteLine("The sign of the product is \"+\"");
                }
            }
            else if (b >= 0)
            {
                if ((a >= 0) ^ (c >= 0))
                {
                    Console.WriteLine("The sign of the product is \"-\"");
                }
                else
                {
                    Console.WriteLine("The sign of the product is \"+\"");
                }
            }
            else if (c >= 0)
            {
                if ((b >= 0) ^ (a >= 0))
                {
                    Console.WriteLine("The sign of the product is \"-\"");
                }
                else
                {
                    Console.WriteLine("The sign of the product is \"+\"");
                }
                
            }
            else if ((a <= 0) && (b <= 0) && (c <= 0))
            {
                Console.WriteLine("The sign of the product is \"-\"");
            }
                 
        }
    }
}
