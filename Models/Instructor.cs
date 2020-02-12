using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DF984515MIS4200.Models
{
    public class Instructor
    {
        [Key]
        public int instructorID { get; set; }
        [Display (Name ="Full Name")]
        public string fullName { get { return lastName + ", " + firstName; } }
        [Display (Name = "First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "Email Address")]
        public string email { get; set; }
        [Display(Name = "Phone Number")]
        public string phoneNumber { get; set; }

        public ICollection<Course> Course { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}