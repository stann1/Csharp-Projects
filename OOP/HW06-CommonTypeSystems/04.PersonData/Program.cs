using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PersonData
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person("Pesho", 32);
            Person anotherPerson = new Person("Stamat");

            Console.WriteLine(myPerson);
            Console.WriteLine(anotherPerson);
        }
    }
}
