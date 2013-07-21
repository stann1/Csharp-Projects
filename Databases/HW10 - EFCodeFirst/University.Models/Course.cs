using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public class Course
    {
        private ICollection<Student> students;
        private ICollection<Homework> homeworks;
        private ICollection<Material> materials;

        public Course()
        {
            this.students = new HashSet<Student>();
            this.homeworks = new HashSet<Homework>();
            this.materials = new HashSet<Material>();
        }

        [Key]
        public int CourseId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }       

        public virtual ICollection<Material> Materials
        {
            get
            {
                return this.materials;
            }
            set
            {
                this.materials = value;
            }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get
            {
                return this.homeworks;
            }
            set
            {
                this.homeworks = value;
            }
        }

        public virtual ICollection<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }
    }
}
