using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Discipline math = new Discipline("Math101", 1, 12);
            Discipline cPlusPlus = new Discipline("C++", 3, 7);
            
            Teacher algorithmTeacher = new Teacher("Johny Bravo", new List<Discipline> { math, cPlusPlus});
            Console.WriteLine(algorithmTeacher.Disciplines[1].Name);

            Student goodStudent = new Student("Myumyun", 2);
            Student badStudent = new Student("Asito", 1);
            badStudent.Comment("I suck at Math");

            SchoolClass algorithms = new SchoolClass(new List<Student> { goodStudent, badStudent }, new List<Teacher> { algorithmTeacher }, "Algorithms 101");

            Student uglyStudent = new Student("Boiko", 9000);
            algorithms.AddStudent(uglyStudent);

            School mySchool = new School(new List<SchoolClass> { algorithms });
            Console.WriteLine(mySchool.Classes[0].TextID);
                                    
        }
    }
}
