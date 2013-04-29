using System;
using System.Linq;

namespace _02.RefactorPerson
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Person createdPerson = CreatePersonByMagicNumber(12);
            Console.WriteLine("Name:{0}, age:{1}, gender:{2}", createdPerson.Name, createdPerson.Age, createdPerson.Gender);

        }

        static Person CreatePersonByMagicNumber(byte magicNumber)
        {
            Person person = new Person();
            person.Age = magicNumber;
            if (magicNumber % 2 == 0)
            {
                person.Name = "The Dude";
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "The Chick";
                person.Gender = Gender.Female;
            }

            return person;
        }
    }
}
