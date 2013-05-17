using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStructure
{
    public class School
    {
        public List<Course> Courses { get; private set; }

        public School()
        {
            this.Courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            this.Courses.Add(course);
        }
    }
}
