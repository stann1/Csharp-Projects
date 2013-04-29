using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalSpecies
{
    public abstract class Cat : Animal, ISound
    {
        public Cat(string name, int age, string sex)
            : base(name, age, sex)
        {
        }

        //Interface method        
        public void MakeSound()
        {
            string sound = string.Format("Cat {0} says: I am an independant cat.", this.Name);
            Animal.PrintSoundToConsole(sound);
        }
    }
}
