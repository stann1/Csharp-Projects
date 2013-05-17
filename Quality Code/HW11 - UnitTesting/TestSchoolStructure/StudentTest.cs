using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolStructure;

namespace TestSchoolStructure
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Student_CanNameBeEmpty()
        {
            Student student = new Student("", 12345);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Student_CanIDbeOutsideRange10000to99999()
        {
            Student student = new Student("Pesho", 123456);
        }
    }
}
