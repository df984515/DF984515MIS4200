using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DF984515MIS4200.Models
{
    public class Course
    {
        [Key]
        public int courseID { get; set; }

        public string courseName { get; set; }

        public int instructorID { get; set; }
        public virtual Instructor Instructor { get; set; }

        public ICollection<CourseDetail> CourseDetail { get; set; }

    }
}