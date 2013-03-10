using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Acho", "Bachov", 5));
            students.Add(new Student("Boiko", "Borisov"));
            students.Add(new Student("Gosho", "Peshev", 4));
            students.Add(new Student("Kolyo", "Manolev", 6));
            students.Add(new Student("Muncho", "Munchev", 3));
            students.Add(new Student("Pesho", "Goshev", 5));
            students.Add(new Student("Stamo", "Stamov", 3));
            students.Add(new Student("Stamat", "Angelov", 6));
            students.Add(new Student("Ku", "Rec", 3));
            students.Add(new Student("Han", "Kubrat"));

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Mao", "Tzedzun", 99.90, 18));
            workers.Add(new Worker("Bao", "Gedzun", 199.90, 12));
            workers.Add(new Worker("Bai", "Mangal", 79.90, 2));
            workers.Add(new Worker("Mehmed", "Mehmedov", 299.90, 10));
            workers.Add(new Worker("Kolyo", "Justkolyo", 122, 9));
            workers.Add(new Worker("Pan", "Asonic", 399.90, 16));
            workers.Add(new Worker("Fat", "Joe"));
            workers.Add(new Worker("Art", "Dedzun", 99.90, 18));
            workers.Add(new Worker("Bart", "Tzedzun", 699.90, 22));
            workers.Add(new Worker("Gan", "Yo",100, 1));

            var studentsByGrade =
                from student in students
                orderby student.Grade
                select student;

            Console.WriteLine("Students sorted by grade (ascending):");
            foreach (var student in studentsByGrade)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            var workersBySalary =
                from worker in workers
                orderby worker.MoneyPerHour() descending
                select worker;

            Console.WriteLine("Workers sorted by salary per hour (descending):");
            foreach (var worker in workersBySalary)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();

            //Merging the lists and sorting:
            var mergedList = students.Concat<Human>(workers);

            var sortedPersonByName =
                from person in mergedList
                orderby person.FirstName, person.LastName
                select person;

            Console.WriteLine("Merged person, sorted by first and last names:");
            foreach (var person in sortedPersonByName)
            {
                Console.WriteLine(person);
            }

        }
    }
}
