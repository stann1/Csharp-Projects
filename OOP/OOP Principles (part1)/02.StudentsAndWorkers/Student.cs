using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    class Student : Human
    {
        public int Grade { get; private set; }

        //Constructors
        public Student(string firstName, string lastName, int grade = 2)              //default grade is 2, max is 6
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.FirstName);
            sb.Append(" ");
            sb.Append(this.LastName);
            sb.AppendFormat(", grade: {0}", this.Grade);

            return sb.ToString();
        }
        
    }
}
