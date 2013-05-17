using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStructure
{
    public class Course
    {   
        public const int MaxStudents = 30;
        public List<Student> Students { get; private set; }
        public string Name { get; private set; }

        public Course(string name)
        {
            if (name == null || name == string.Empty)
            {
                throw new ArgumentNullException("course", "The course name cannot be empty");
            }
            this.Name = name;
            this.Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if (this.Students.Count >= MaxStudents)
            {
                throw new ArgumentOutOfRangeException("List of students", "The student in the course cannot be more than 30");
            }
            if (StudentIsRegistered(student))
            {
                throw new ArgumentException("student", "The student already exists in the database of the course");
            }
            this.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (this.Students.Count == 0)
            {
                throw new ArgumentOutOfRangeException("List of students", "The students in the course cannot be less than 0");
            }
            this.Students.Remove(student);
        }

        private bool StudentIsRegistered(Student student)
        {
            for (int i = 0; i < this.Students.Count; i++)
            {
                Student registeredStudent = this.Students[i];
                if (registeredStudent.IdNumber == student.IdNumber)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
