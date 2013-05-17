using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolStructure;

namespace TestSchoolStructure
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Course_CanNameBeEmpty()
        {
            Course course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Course_CourseCanHoldMoreThan30Students()
        {
            Course mathCourse = new Course("math");

            for (int i = 0; i < Course.MaxStudents + 1; i++)
            {
                mathCourse.AddStudent(new Student("Student" + i, 10000 + i));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Course_CourseCanHoldLessThanZeroStudents()
        {
            Course mathCourse = new Course("math");

            mathCourse.RemoveStudent(new Student("Gosho", 12345));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Course_CourseAllowsDuplicateIDs()
        {
            Course mathCourse = new Course("math");

            mathCourse.AddStudent(new Student("Gosho", 12345));
            mathCourse.AddStudent(new Student("Pesho", 12345));
        }
    }
}
