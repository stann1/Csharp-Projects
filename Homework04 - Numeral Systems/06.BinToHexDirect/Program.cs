﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.BinToHexDirect
{
    class Program
    {
        static void Main(string[] args)
        {
            string binary = "101101";
            
            while (binary.Length % 4 != 0)                   //Adds zeroes in front
            {
                binary = '0' + binary;
            }
            string hex = "";

            for (int i = 0; i < binary.Length; i += 4)
            {

                switch (binary.Substring(i, 4))
                {
                    case "0000": hex += '0'; break;
                    case "0001": hex += '1'; break;
                    case "0010": hex += '2'; break;
                    case "0011": hex += '3'; break;
                    case "0100": hex += '4'; break;
                    case "0101": hex += '5'; break;
                    case "0110": hex += '6'; break;
                    case "0111": hex += '7'; break;
                    case "1000": hex += '8'; break;
                    case "1001": hex += '9'; break;
                    case "1010": hex += 'A'; break;
                    case "1011": hex += 'B'; break;
                    case "1100": hex += 'C'; break;
                    case "1101": hex += 'D'; break;
                    case "1110": hex += 'E'; break;
                    case "1111": hex += 'F'; break;
                    default: hex += ""; break;
                }



            }

            Console.WriteLine(hex);
            
        }
    }
}
