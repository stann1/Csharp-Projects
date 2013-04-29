using System;
using System.Linq;

namespace _02.RefactorPerson
{
    class Person
    {
        private string name;
        private byte age;
        private Gender gender;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("The name provided cannot be empty");
                }
                this.name = value;
            }
        }

        public byte Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 130)
                {
                    throw new ArgumentOutOfRangeException("You must provide a valid age");
                }
                this.age = value;
            }
        }

        public Gender Gender 
        {
            get { return this.gender; }
            set
            {
                if (!(value is Gender))
                {
                    throw new ArgumentException("You must input a valid gender - Male/Female");
                }
                this.gender = value;
            }
        }
        

    }
}
