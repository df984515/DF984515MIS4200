using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DF984515MIS4200.Models
{
    public class Course
    {
        [Key]
        public int courseID { get; set; }
        [Display(Name = "Course Name")]
        public string courseName { get; set; }
        [Display(Name = "Start Date")]
        public DateTime startDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime endDate { get; set; }

        public int instructorID { get; set; }
        public virtual Instructor Instructor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}