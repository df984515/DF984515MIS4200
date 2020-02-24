using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DF984515MIS4200.Models
{
    public class Instructor
    {
        public int instructorID { get; set; }
        [Display(Name = "First Name")]
        [Required]
        [StringLength(50)]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        [StringLength(50)]
        public string lastName { get; set; }
        [Display(Name = "Email Address")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string email { get; set; }
        [Display(Name = "Phone Number")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$", ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phoneNumber { get; set; }
        [Display(Name = "Instructor Name")]
        public string fullName { get { return lastName + ", " + firstName; } }

        public ICollection<Course> Course { get; set; }
    }
}