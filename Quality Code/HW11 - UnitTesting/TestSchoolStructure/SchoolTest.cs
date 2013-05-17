using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolStructure;

namespace TestSchoolStructure
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void School_CourseIsAddedToList()
        {
            Course mathCourse = new Course("math");
            School localHighSchool = new School();

            localHighSchool.AddCourse(mathCourse);

            Assert.IsTrue(localHighSchool.Courses.Contains(mathCourse));
        }
    }
}
