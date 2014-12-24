using HRSuite.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HRSuite.DAL
{
    public class EmployeeContext : DbContext
    {

        public EmployeeContext()
            : base("EmployeeContext")
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeInfo> EmployeeInfo { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Employee>()
                .HasMany(r => r.Roles).WithMany(e => e.Employees)
                .Map(t => t.MapLeftKey("EmployeeID")
                    .MapRightKey("RoleID")
                    .ToTable("EmployeeRole"));

        }
    }
}