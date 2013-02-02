using System;
using System.Linq;
using System.Text;


namespace _06.MaskString
{
    class MaskString
    {
        static void Main(string[] args)
        {
            //string text = "Less than twenty";              //used for testing

            Console.WriteLine("Enter a sting (max 20char):");
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 20; i++)
            {
                if (i < text.Length)
                {
                    sb.Append(text[i]);
                }
                else
                {
                    sb.Append('*');
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
