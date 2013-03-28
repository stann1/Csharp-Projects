using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PersonData
{
    class Person
    {
        public string Name { get; set; }
        public byte? Age { get; set; }

        public Person(string name, byte? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Name: {0} \n", this.Name);
            if (this.Age != null)
            {
                sb.AppendFormat("Age: {0}", this.Age);
            }
            else
            {
                sb.AppendLine("Age is not specified");
            }
            return sb.ToString();
        }
    }
}
