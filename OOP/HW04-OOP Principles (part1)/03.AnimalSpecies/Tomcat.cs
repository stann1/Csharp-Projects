using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalSpecies
{
    public class Tomcat : Cat, ISound
    {
        private const string sex = "male";          //Tomcats are always male

        public Tomcat(string name, int age)
            : base(name, age, sex)
        {
        }

        //Interface method        
        public void MakeSound()
        {
            string sound = string.Format("Tomcat {0} says: I am an independant cat. Also, I'm very strong and fight for females", this.Name);
            Animal.PrintSoundToConsole(sound);
        }
    }
}
