using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string AdditionalInformation { get; set; }
        
        public bool IsOlderThan(Student otherStudent)        {

            DateTime firstStudentBirthDate = DateTime.Parse(this.BirthDate);

            DateTime secondStudentBirthDate = DateTime.Parse(otherStudent.BirthDate);

            return firstStudentBirthDate < secondStudentBirthDate;
        }
    }
}
