using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.ReadFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\win.ini";

            try
            {
                string contents = File.ReadAllText(path);
                Console.WriteLine(contents);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The specified path is not in a valid format. Please use allowed characters only!");

            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path or file name is too long! Only up to 248 characters are allowed");

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found! Please make sure the path is correct.");
                
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You don't have permission to read this file!");
            }

        }
    }
}
