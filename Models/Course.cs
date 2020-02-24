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
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }
}