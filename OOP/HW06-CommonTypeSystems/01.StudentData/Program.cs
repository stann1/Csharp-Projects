using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.StudentData
{
    //Tasks 1,2,3 are included in this project

    class Program
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student("Gosho", "Goshev", "Peshev", 11229988, "Dolna mahala 2", "0887112233", "gosho.lekia@abv.bg", "Ribolov101", Specialty.SocialStudies, Faculty.SocialSciences, University.BusmanciUniversity);
            Student secondStudent = new Student("Gosho", "Goshev", "Peshev", 11111111, "Mrasna Gad 8", "0887112233", "gosho.lekia@abv.bg", "Tourism101", Specialty.Economics, Faculty.NaturalSciences, University.BusmanciUniversity);
            Student anotherStudent = new Student("Pesho", "Goshev", "Peshev", 11339988, "Gorna Mahala 13", "911", "pesho_ludoto@yahoo.com", "Neurology202", Specialty.Medicine, Faculty.MedicalFaculty, University.UniversityForMediocreResults);

            //Console.WriteLine(firstStudent);
            //Console.WriteLine(firstStudent.GetHashCode());
            //Console.WriteLine(firstStudent.Equals(secondStudent));

            Student notClonedStudent = firstStudent;
            Student clonedStudent = firstStudent.Clone();            

            firstStudent.FirstName = "Petkan";
            Console.WriteLine(firstStudent);
            Console.WriteLine(notClonedStudent);
            Console.WriteLine(clonedStudent);

            Console.WriteLine(clonedStudent.CompareTo(secondStudent));
        }
    }
}
