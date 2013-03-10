using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalSpecies
{
    public abstract class Animal
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Sex { get; private set; }

        //Base Constructor
        public Animal(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        //Method for printing each animal's sound
        public static void PrintSoundToConsole (string sound)
        {
            Console.WriteLine(sound);
        }
        
    }
}
