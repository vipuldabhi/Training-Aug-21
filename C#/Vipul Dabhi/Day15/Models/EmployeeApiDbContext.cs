using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Day15_Assignment.Models
{
    public class EmployeeApiDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Assignment> Assignments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.\Sqlexpress;database=EmployeeApiDb;trusted_connection=true;");
        }

        public EmployeeApiDbContext(DbContextOptions<EmployeeApiDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(e => e.EmployeeId);
            modelBuilder.Entity<Assignment>().HasKey(a => a.AssignmentId);

            modelBuilder.Entity<Employee>().Property(e => e.isActive).HasDefaultValue(true);
            modelBuilder.Entity<Assignment>().Property(a => a.isActive).HasDefaultValue(true);
        }
    }
}