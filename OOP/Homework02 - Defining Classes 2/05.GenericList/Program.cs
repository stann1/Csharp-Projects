using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GenericListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>(3);
            list.AddElement(16);
            list.AddElement(4);
            list.AddElement(6);

            Console.WriteLine("List size: {0}", list.Count);

            list.InsertElementAtPosition(22, 2);
            Console.WriteLine("List size: {0}", list.Count);

            Console.WriteLine(list);
            
        }
    }
}
