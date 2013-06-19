using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentData
{
    class Student : IComparable<Student>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Student(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
        }

        public int CompareTo(Student other)
        {
            return string.Compare(this.LastName, other.LastName) * 2 + string.Compare(this.FirstName, other.LastName);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
