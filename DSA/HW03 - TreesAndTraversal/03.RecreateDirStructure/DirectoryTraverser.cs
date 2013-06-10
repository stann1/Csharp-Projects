using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _03.RecreateDirStructure
{
    public static class DirectoryTraverser
    {
        public static Folder RecreateFolderStructure(string path)
        {
            string folderName = GetNameFromPath(path);
            Folder folder = new Folder(folderName);
            TraverseDirDFS(new DirectoryInfo(path), folder);
            return folder;
        }

        private static string GetNameFromPath(string path)
        {
            int lastSeparatorIndex = path.LastIndexOf('\\');
            if (lastSeparatorIndex == path.Length - 1)
            {
                int prevIndex = path.LastIndexOf('\\', lastSeparatorIndex - 1);
                string folderName = path.Substring(prevIndex + 1, lastSeparatorIndex - prevIndex - 1);
                return folderName;
            }
            else
            {
                string folderName = path.Substring(lastSeparatorIndex + 1);
                return folderName;
            }            
        }

        private static void TraverseDirDFS(DirectoryInfo dir, Folder currFolder)
        {
            var fileList = dir.GetFiles();

            foreach (var file in fileList)
            {
                long fileSize = file.Length;
                string fileName = file.Name;
                File currentFile = new File(fileName, fileSize);
                currFolder.AddFile(currentFile);
            }

            DirectoryInfo[] children = dir.GetDirectories();

            // For each child, add it to current folder go and visit its subtree
            foreach (DirectoryInfo child in children)
            {
                Folder subFolder = new Folder(child.Name);
                currFolder.AddSubFolder(subFolder);
                TraverseDirDFS(child, subFolder);
            }
        }
    }
}
