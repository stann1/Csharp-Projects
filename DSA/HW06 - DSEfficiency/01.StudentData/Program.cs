using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentData
{
    class Program
    {
        static SortedDictionary<string, List<Student>> studentData = new SortedDictionary<string, List<Student>>(); 
      
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"../../students.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] data = line.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                    AddStudentToDataBase(data[2], new Student(data[0], data[1]));                    
                    line = reader.ReadLine();
                }              

            }

            foreach (var entry in studentData)
            {
                List<Student> list = entry.Value;
                string course = entry.Key;
                list.Sort();

                Console.Write(course + ": ");
                Console.WriteLine(string.Join(", ", list));
            }

        }

        private static void AddStudentToDataBase(string course, Student student)
        {
            if (!studentData.ContainsKey(course))
            {
                studentData[course] = new List<Student>();
            }
            studentData[course].Add(student);
        }
    }
}
