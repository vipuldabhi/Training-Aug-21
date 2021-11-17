using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day12_13.Models
{
    public class ToyContext : DbContext
    {
        public ToyContext()
        {
        }

        public ToyContext(DbContextOptions<ToyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerDetails> CustomerDetails { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<PlantsDetails> PlantsDetails { get; set; }
        public virtual DbSet<ToysDetails> ToysDetails { get; set; }
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=VIPULDABHI\\SQLEXPRESS;Database=ToyDB;Trusted_Connection=True;");
            }
        }
    }



}
