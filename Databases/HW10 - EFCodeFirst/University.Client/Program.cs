using System;
using System.Data.Entity;
using System.Linq;
using University.Data;
using University.Data.Migrations;
using University.Models;

namespace University.Client
{
    class Program
    {
        static UniversityContext db = new UniversityContext();

        static void Main(string[] args)
        {

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<UniversityContext, Configuration>());

            //add some initial data

            //var mathCourse = new Course();
            //mathCourse.Name = "Math101";
            //mathCourse.Description = "Math course for beginners";
            //db.Courses.Add(mathCourse);

            //var biologyCourse = new Course();
            //biologyCourse.Name = "Biology202";
            //biologyCourse.Description = "Advanced Biology";
            //db.Courses.Add(biologyCourse);

            //var student = new Student();
            //student.Name = "Gosho Petrov";
            //student.StudentNumber = 10001;
            //student.Courses.Add(mathCourse);
            //db.Students.Add(student);

            //db.SaveChanges();

            ListAllCoursesAndStudents();

        }

        static void ListAllCoursesAndStudents()
        {
            using (db)
            {
                var courses = db.Courses.ToList();

                foreach (var course in courses)
                {
                    Console.WriteLine("Course name: {0}", course.Name);
                    Console.WriteLine("Students in the course:");
                    foreach (var student in course.Students)
                    {
                        Console.WriteLine(student.Name);
                    }
                }
            }
            
        }
    }
}
