using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.StudentData
{
    class Student : ICloneable, IComparable
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Specialty Specialty { get; set; }
        public Faculty Faculty { get; set; }
        public University University { get; set; }

        //Constructor
        public Student(string firstName, string middleName, string lastName, int ssn, string address, string mobilePhone,
            string email, string course, Specialty specialty, Faculty faculty, University university)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.Faculty = faculty;
            this.University = university;
        }

        //Methods
        public override bool Equals(object studentAsObj)
        {
            Student student = studentAsObj as Student;
            
            //Students are considered equal if they have all matching names and a social security number
            if (this.FirstName == student.FirstName && this.MiddleName == student.MiddleName && 
                this.LastName == student.LastName && this.SSN == student.SSN)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Student name: {0} {1} {2} \n", this.FirstName, this.MiddleName, this.LastName);
            sb.AppendFormat("SSN: {0} \n", this.SSN);
            sb.AppendFormat("Address: {0} \n", this.Address);
            sb.AppendFormat("Phone: {0} \n", this.MobilePhone);
            sb.AppendFormat("Email: {0} \n", this.Email);
            sb.AppendFormat("Course: {0}, Specialy: {1}, Faculty: {2}. \n", this.Course, this.Specialty, this.Faculty);
            sb.AppendFormat("University: {0} \n", this.University);
            return sb.ToString();
        }

        public override int GetHashCode()
        {
            int hash = this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.SSN.GetHashCode();
            return hash;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return firstStudent.Equals(secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !firstStudent.Equals(secondStudent);
        }

        //Interface method
        public Student Clone()
        {
            Student clone = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.MobilePhone,
                this.Email, this.Course, this.Specialty, this.Faculty, this.University);
            return clone;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }


        public int CompareTo(object studentAsObj)
        {
            Student student = studentAsObj as Student;
            if (this.FirstName != student.FirstName)
            {
                return this.FirstName.CompareTo(student.FirstName);
            }
            if (this.MiddleName != student.MiddleName)
            {
                return this.MiddleName.CompareTo(student.MiddleName);
            }
            if (this.LastName != student.LastName)
            {
                return this.LastName.CompareTo(student.LastName);
            }
            if (this.SSN != student.SSN)
            {
                return (this.SSN - student.SSN);
            }
            return 0;
        }        
        
    }
}
