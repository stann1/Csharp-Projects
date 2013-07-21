﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public class Homework
    {
        public Homework()
        {
        }
        
        [Key]
        public int HomeworkId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime TimeSent { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }        
        public virtual Student Student { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }        
        public virtual Course Course { get; set; }
        
    }
}
