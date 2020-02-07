using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DF984515MIS4200.Models
{
    public class Customer
    {
        public int customerID { get; set; }
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Phone Number")]
        public string phone { get; set; }
        [Display(Name = "Customer Since")]
        public DateTime customerSince { get; set; }

        public ICollection<Orders> Orders{ get; set; }

        public string fullName { get { return lastName + ", " + firstName; } }

    }
}