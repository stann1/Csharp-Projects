using System;
using System.Linq;
using System.Text;


namespace _01.ExtendStringbuilder
{
    public static class Extensions
    {
        public static StringBuilder SubString(this StringBuilder sb, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            for (int i = index; i < index + length; i++)
            {
                result.Append(sb[i]);
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("astalavista");
            StringBuilder sub = sb.SubString(0, 6);
            Console.WriteLine(sub);
        }
    }
}
