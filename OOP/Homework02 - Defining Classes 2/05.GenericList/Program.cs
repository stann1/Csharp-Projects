using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GenericListOperations                  //includes tasks 5 - 7
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            list.AddElement(16);
            list.AddElement(4);
            list.AddElement(5);
            list.AddElement(10);

            Console.WriteLine("List size: {0}", list.Count);
            
            list.InsertElementAtPosition(22, 2);
            Console.WriteLine("List size: {0}", list.Count);

            Console.WriteLine(list);
            
            list.InsertElementAtPosition(12, 5);
            

            list.InsertElementAtPosition(12, 6);
            Console.WriteLine(list);

            int max = list.Max();
            Console.WriteLine(max);
        }
    }
}
