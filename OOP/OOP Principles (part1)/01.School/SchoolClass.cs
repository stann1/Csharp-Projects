using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class SchoolClass : ICommentable
    {
        public string TextID { get; set; }
        public List<Student> Students { get; private set; }
        public List<Teacher> Teachers { get; private set; }

        //Constructor
        public SchoolClass(List<Student> students, List<Teacher> teachers, string textId)
        {
            this.Students = students;
            this.Teachers = teachers;
            this.TextID = textId;
        }

        //Methods
        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }

        //Interface method:
        public void Comment(string comment)
        {
            Console.WriteLine("The class comments: {0}", comment);
        }
    }
}
