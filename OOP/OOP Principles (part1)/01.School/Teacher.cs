using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class Teacher : Person, ICommentable
    {
        public List<Discipline> Disciplines { get; private set; }

        //Constructor
        public Teacher(string name, List<Discipline> disciplines)
            : base(name)
        {
            this.Disciplines = disciplines;
        }

        //Methods
        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        //Interface method:
        public void Comment(string comment)
        {
            Console.WriteLine("The teacher comments in an angry voice: {0}", comment);
        }
    }
}
