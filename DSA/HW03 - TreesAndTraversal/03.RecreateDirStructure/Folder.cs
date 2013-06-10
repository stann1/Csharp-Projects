using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RecreateDirStructure
{
    public class Folder
    {
        //Constructors
        public Folder()
        {
            this.Files = new List<File>();
            this.ChildFolders = new List<Folder>();
        }

        public Folder(string name) : this()
        {
            this.Name = name;            
        }

        //Properties
        public string Name { get; set; }

        public List<File> Files { get; private set; }

        public List<Folder> ChildFolders { get; private set; }

        //Methods
        public void AddFile(File file)
        {
            this.Files.Add(file);
        }

        public void AddSubFolder(Folder folder)
        {
            this.ChildFolders.Add(folder);
        }

        public void PrintFiles()
        {
            foreach (var file in this.Files)
            {
                Console.WriteLine("Name: {0}, size: {1}", file.Name, file.Size);
            }
        }

        public void PrintFolders()
        {
            foreach (var folder in this.ChildFolders)
            {
                Console.WriteLine(folder.Name);
            }
        }

        public void GetSize()
        {
            long fileSize = GetSizeFromSubTree(this);
            Console.WriteLine("The size of folder {0} is: {1}", this.Name, fileSize);
        }

        private long GetSizeFromSubTree(Folder currentFolder)
        {
            long currentSize = 0;

            foreach (File file in currentFolder.Files)
            {
                currentSize += file.Size;
            }

            foreach (Folder sub in currentFolder.ChildFolders)
            {
                long subFolderSize = GetSizeFromSubTree(sub);
                currentSize += subFolderSize;
            }

            return currentSize;
        }
    }
}
