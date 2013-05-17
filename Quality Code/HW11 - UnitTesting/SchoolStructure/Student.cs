using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStructure
{
    public class Student
    {
        public string Name { get; private set; }
        public int IdNumber { get; private set; }

        public Student(string name, int idNumber)
        {
            if (name == null || name == string.Empty)
            {
                throw new ArgumentNullException("name", "The student's name cannot be empty");
            }
            if (idNumber < 10000 || idNumber > 99999)
            {
                throw new ArgumentOutOfRangeException("id number", "The student's ID number must be in the range 10000 - 99999");
            }
            this.Name = name;
            this.IdNumber = idNumber;            
        }
    }
}
