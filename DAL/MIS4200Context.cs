using DF984515MIS4200.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DF984515MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
        }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<Customer> Customer { get; set; }

    }
}