using DF984515MIS4200.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DF984515MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,DF984515MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        


        // add this method - it will be used later
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<DF984515MIS4200.Models.Instructor> Instructors { get; set; }

        public System.Data.Entity.DbSet<DF984515MIS4200.Models.CourseDetail> CourseDetails { get; set; }
    }
}