using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public class Material
    {
        public Material()
        {
        }

        [Key]
        public int MaterialId { get; set; }

        public string Name { get; set; }
    }
}
