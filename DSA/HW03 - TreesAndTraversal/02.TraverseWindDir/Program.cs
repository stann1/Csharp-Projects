using System;
using System.IO;
using System.Linq;

namespace _02.TraverseWindDir
{
    class Program
    {
        static void Main(string[] args)
        {
            // Windows dir sometimes throw exceptions due to access rights, therefore I changed it
            // Check output.txt in main project dir
            DirectoryTraverser.TraverseDirDFS("C:\\Program Files\\");
        }

    }
}
