using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalSpecies
{
    public class Kitten : Cat, ISound
    {
        private const string sex = "female";           //kittens are always female

        public Kitten(string name, int age)
            : base(name, age, sex)
        {
        }
        
        //Interface method        
        public void MakeSound()
        {
            string sound = string.Format("Kitten {0} says: I am an independant cat. Also, I'm very soft", this.Name);
            Animal.PrintSoundToConsole(sound);
        }
    }
}
