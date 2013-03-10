using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalSpecies
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Sharo", 2, "male");
            myDog.MakeSound();

            Cat kitten = new Kitten("Lola", 4);
            Console.WriteLine(kitten.Sex);
            kitten.MakeSound();                        //Different sound results for the two cats, because one is initiated as a Cat and the other as a Kitten

            Kitten secondKitten = new Kitten("Muhla", 1);
            secondKitten.MakeSound();

            List<Animal> animalList = new List<Animal>();
            animalList.Add(new Dog("Burkan", 5, "male"));
            animalList.Add(new Dog("Penka", 2, "female"));
            animalList.Add(new Kitten("Karma", 1));
            animalList.Add(new Kitten("Shusha", 3));
            animalList.Add(new Tomcat("Roshko", 6));
            animalList.Add(new Frog("Galoshko", 1, "male"));
            animalList.Add(new Frog("Zelen", 2, "male"));

            var animalsByKind =
                (from animal in animalList
                 group animal by animal.GetType().Name into newGroup
                 select new
                 {
                     animalKind = newGroup.Key,
                     averageAge =
                          (from sortedAnimals in newGroup
                           select sortedAnimals.Age).Average()
                 });

            Console.WriteLine("Animal kinds with average age:");
            foreach (var group in animalsByKind)
            {
                Console.WriteLine(group);
            }
        }
    }
}
