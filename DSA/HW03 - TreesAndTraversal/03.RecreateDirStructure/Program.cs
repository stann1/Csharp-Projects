using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RecreateDirStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder programFiles = DirectoryTraverser.RecreateFolderStructure("C:\\Program Files");

            Console.WriteLine(programFiles.Name);
            Console.WriteLine("Files and folders in the main dir:");
            programFiles.PrintFiles();
            programFiles.PrintFolders();            

            programFiles.GetSize();            
        }
    }
}
