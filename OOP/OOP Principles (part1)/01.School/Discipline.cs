using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class Discipline : ICommentable
    {
        public string Name { get; set; }
        public int LecturesNumber { get; set; }
        public int ExcercisesNumber { get; set; }

        //Constructor
        public Discipline(string name, int lectureNUmber, int excerciseNumber)
        {
            this.Name = name;
            this.LecturesNumber = lectureNUmber;
            this.ExcercisesNumber = excerciseNumber;
        }

        //Interface method
        public void Comment(string comment)
        {
            Console.WriteLine("The discipline comments: {0}", comment);
        }
    }
}
