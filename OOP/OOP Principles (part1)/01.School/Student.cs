using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class Student : Person, ICommentable
    {
        public int StudentID { get; set; }

        //Constructor
        public Student(string name, int studentID)
            : base(name)
        {
            this.StudentID = studentID;
        }
                
        //Interface method:
        public void Comment(string comment)
        {
            Console.WriteLine("The student comments with a humorous tone: {0}", comment);
        }
    }
}
