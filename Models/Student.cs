using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DF984515MIS4200.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string studentYear { get; set; }
        public string fullName { get { return lastName + ", " + firstName; } }
        public ICollection<Course> Course { get; set; }

    }
}