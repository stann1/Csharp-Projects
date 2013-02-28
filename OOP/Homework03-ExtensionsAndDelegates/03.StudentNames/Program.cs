using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.StudentNames
{
    class Program                           //Tasks 3,4,5 are combined in this project
    {
        static void Main(string[] args)
        {
            Student[] studentData = new Student[]
                                                {
                                                    new Student() {FirstName = "John", LastName= "Doe", Age = 21},
                                                    new Student() {FirstName = "Ivan", LastName= "Petrov", Age = 26},
                                                    new Student() {FirstName = "Pesho", LastName= "Ivanov", Age = 19},
                                                    new Student() {FirstName = "Gosho", LastName= "Valkanov", Age = 54},
                                                    new Student() {FirstName = "Jivko", LastName= "Jivkov", Age = 31},
                                                };

            //task 3
            var studentsWithFirstnameSmaller =
                from student in studentData
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;

            Console.WriteLine("Student whose first name is lexographically before the last name:");
            foreach (var name in studentsWithFirstnameSmaller)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName);
            }
            Console.WriteLine();

            //task 4
            var studentsBetween18and24 =
                from student in studentData
                where student.Age >= 18 && student.Age <= 24
                select student;

            Console.WriteLine("Students aged bewteen 18 and 24:");
            foreach (var name in studentsBetween18and24)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName);
            }
            Console.WriteLine();

            //task 5 with lambda
            var studentsByName = studentData.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

            Console.WriteLine("Students order by first then by last name:");
            foreach (var student in studentsByName)
            {
                Console.WriteLine("{0} {1}, age {2}", student.FirstName, student.LastName, student.Age);
            }
            Console.WriteLine();

            //task 5 with LINQ
            var studentsByNameQuery =
                from student in studentData
                orderby student.FirstName descending, student.LastName descending
                select student;

            Console.WriteLine("Students order by first then by last name (LINQ):");
            foreach (var student in studentsByNameQuery)
            {
                Console.WriteLine("{0} {1}, age {2}", student.FirstName, student.LastName, student.Age);
            }
            Console.WriteLine();
        }
    }
}
