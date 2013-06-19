using System;
using System.Linq;

namespace _04.ImplementHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomHashTable<string, int> studentGrades = new CustomHashTable<string, int>();
            studentGrades.Add("Pesho", 4);
            studentGrades.Add("Gosho", 2);
            studentGrades.Add("Evlogi", 3);

            Console.WriteLine("Capacity: {0}", studentGrades.Capacity);
            Console.WriteLine("Current count: {0}", studentGrades.CurrentCount);

            var gradeGosho = studentGrades.Find("Gosho");
            Console.WriteLine("Grade of Gosho: " + gradeGosho);
            Console.WriteLine("Grade of Gosho(by index): " + studentGrades["Gosho"]);

            studentGrades["Evlogi"] = 6;
            Console.WriteLine(studentGrades["Evlogi"]);

            studentGrades.Remove("Pesho");
            Console.WriteLine("Capacity after removal: {0}", studentGrades.Capacity);
            Console.WriteLine("Current count after removal: {0}", studentGrades.CurrentCount);
        }
    }
}
