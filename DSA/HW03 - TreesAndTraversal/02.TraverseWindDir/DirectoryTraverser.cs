using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _02.TraverseWindDir
{
    public static class DirectoryTraverser
    {
        public static void TraverseDirDFS(string path)
        {
            StreamWriter writer = new StreamWriter(@"..\..\output.txt");
            StringBuilder output = new StringBuilder();
            TraverseDirDFS(new DirectoryInfo(path), string.Empty, output);

            using (writer)
            {
                writer.Write(output);
            }
        }

        private static void TraverseDirDFS(DirectoryInfo dir, string spaces, StringBuilder output)
        {
            var fileList = dir.GetFiles();

            foreach (var file in fileList)
            {
                if (file.Name.Contains(".exe"))
                {
                    output.AppendLine(spaces + file.FullName);
                }
                
            }

            DirectoryInfo[] children = dir.GetDirectories();

            // For each child go and visit its subtree
            foreach (DirectoryInfo child in children)
            {
                TraverseDirDFS(child, spaces + "--", output);
            }
        }
    }
}
