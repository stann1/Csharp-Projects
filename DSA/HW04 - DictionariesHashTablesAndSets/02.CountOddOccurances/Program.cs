using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CountOddOccurances
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keys = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            IDictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var element in keys)
            {
                int counter = 1;
                if (dict.ContainsKey(element))
                {
                    counter = dict[element] + 1;
                }
                dict[element] = counter;
            }

            Console.Write("{");
            foreach (var pair in dict)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write("{0} ", pair.Key);
                }
            }
            Console.WriteLine("}");
        }
    }
}
