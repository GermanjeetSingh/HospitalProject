using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HospitalProject.Models
{
    public partial class DepartmentModel : DbContext
    {
        public DepartmentModel()
            : base("name=DepartmentModel")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(e => e.Doctors)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.contact_num)
                .HasPrecision(10, 0);
        }
    }
}
