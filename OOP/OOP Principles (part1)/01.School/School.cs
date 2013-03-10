using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class School
    {
        public readonly string SchoolName = "Gangnam High";
        public List<SchoolClass> Classes { get; private set; }

        public School(List<SchoolClass> classes)
        {
            this.Classes = classes;
        }
       
        //Methods
        public void AddClass(SchoolClass schoolClass)
        {
            this.Classes.Add(schoolClass);
        }
    }
         
}
