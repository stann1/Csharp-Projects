using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.FloatToBinary
{
    class Program
    {

        static string ConvertExponent(int exp, int sign)
        {            
           string result = "";

            while (exp > 0)
            {
                result += exp % 2;
                exp /= 2;
            }

            string bin = "";
            for (int i = result.Length - 1; i >= 0; i--)
            {
                bin += result[i];
            }
            return bin;
        }

        //static string ConvertMantissa(float mant)
        //{
            
        //}


        static void Main(string[] args)
        {
            float number = -27.25f;

            int sign = number < 0 ? 1 : 0;
            number = Math.Abs(number);

            int exp = (int)number;
            string integer = ConvertExponent(exp, sign);
            Console.WriteLine(integer);

            //float mant = number - exp;
            //string fraction = ConvertMantissa(mant);
        }

        

    }
}
