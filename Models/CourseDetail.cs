using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DF984515MIS4200.Models
{
    public class CourseDetail
    {
        public int coursedetailID { get; set; }
        [Display (Name = "Start Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime startDate { get; set; }
        [Display(Name = "End Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime endDate { get; set; }
        [Display(Name = "Location")]
        [Required]
        [StringLength(50)]
        public string location { get; set; }

        public int courseID { get; set; }
        public virtual Course Course { get; set; }

        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }
}