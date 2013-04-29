using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalSpecies
{
    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, string sex)
            : base(name, age, sex)
        {
        }

        //Interface method
        public void MakeSound()
        {
            string sound = string.Format("Dog {0} says: I am a loyal dog", this.Name);
            Animal.PrintSoundToConsole(sound);
        }

       
    }
}
