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
        [Display (Name = "First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "Email Address")]
        public string email { get; set; }
        [Display(Name = "Phone Number")]
        public string phoneNumber { get; set; }
        [Display(Name = "Student Name")]
        public string fullName { get { return lastName + ", " + firstName; } }

        public ICollection<CourseDetail> CourseDetail { get; set; }
    }
}