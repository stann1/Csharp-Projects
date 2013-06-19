using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04.ImplementHashTable;

namespace _05.ImplementHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomHashSet<int> set = new CustomHashSet<int>(1, 4, 16, 12, 6, 32, 48);
            Console.WriteLine(set.Count);

            set.Add(8);
            set.Remove(6);
            set.Remove(48);

            Console.WriteLine(set.Find(8));
            Console.WriteLine(set.Contains(6));
            Console.WriteLine(set.Contains(4));

            set.UnionWith(new CustomHashSet<int>(3, 4, 16, 17, 32));

            Console.WriteLine("The modified set after union:");
            foreach (var item in set)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            set.IntersectionWith(new CustomHashSet<int>(24, 3, 32, 9, 25));

            Console.WriteLine("The modified set after intersection:");
            foreach (var item in set)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
