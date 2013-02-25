using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace _11.VersionAttribute
{
    [Version("1.10")]
    public struct SampleStructure
    {
        string firstName;
        string lastName;
    }

    [Version("1.12")]
    class Program
    {
        static void Main(string[] args)
        {            
            Type type = typeof(Program);
            
            object[] myObj = type.GetCustomAttributes(false);

            foreach (VersionAttribute attr in myObj)
            {
                Console.WriteLine("program version {0}", attr.Version);                
            }

            
            
        }
    }
}
