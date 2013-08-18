using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Schools.Data;

namespace Schools.WebApi.Models
{
    public class StudentModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public string School { get; set; }
        public IEnumerable<MarkModel> Marks { get; set; }
    }
}