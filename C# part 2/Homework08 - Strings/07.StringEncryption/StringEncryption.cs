using System;
using System.Linq;
using System.Text;

namespace _07.StringEncryption
{
    class StringEncryption
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string for encryption: ");
            string input = Console.ReadLine();
            char[] key = { 'a', 'r', 'k', 'o', 'n' };
            StringBuilder encrypted = new StringBuilder();
            StringBuilder output = new StringBuilder();

            //Encryption
            for (int i = 0, pos = 0; i < input.Length; i++, pos++)
            {
                if (pos == key.Length)
                {
                    pos = 0;
                }
                encrypted.Append((char)(input[i] ^ key[pos]));
            }
            Console.Write("Encrypted result: ");
            Console.WriteLine(encrypted.ToString());

            //Decryption
            for (int i = 0, pos = 0; i < encrypted.Length; i++, pos++)
            {
                if (pos == key.Length)
                {
                    pos = 0;
                }
                output.Append((char)(encrypted[i] ^ key[pos]));
            }
            Console.Write("Decrypted result: ");
            Console.WriteLine(output.ToString());

        }
    }
}
