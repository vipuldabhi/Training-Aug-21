using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StudentWebApi.Models
{
    public partial class StudentContext : DbContext
    {
        public StudentContext()
        {
        }

        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Emergency> Emergencies { get; set; }
        public virtual DbSet<Father> Fathers { get; set; }
        public virtual DbSet<Mother> Mothers { get; set; }
        public virtual DbSet<Reference> References { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=VIPULDABHI\\SQLEXPRESS;Database=Student;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emergency>(entity =>
            {
                entity.ToTable("Emergency");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Relation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.EmergencyNavigation)
                    .HasForeignKey<Emergency>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Emergency__Id__440B1D61");
            });

            modelBuilder.Entity<Father>(entity =>
            {
                entity.ToTable("Father");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Profession)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qualification)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mother>(entity =>
            {
                entity.ToTable("Mother");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Profession)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qualification)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reference>(entity =>
            {
                entity.ToTable("Reference");

                entity.Property(e => e.RefAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefDetails)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefThrough)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.FirstLanguage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfBirth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AddressNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Address)
                    .HasConstraintName("FK__Student__Address__3E52440B");

                entity.HasOne(d => d.FatherNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Father)
                    .HasConstraintName("FK__Student__Father__3F466844");

                entity.HasOne(d => d.MotherNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Mother)
                    .HasConstraintName("FK__Student__Mother__403A8C7D");

                entity.HasOne(d => d.ReferenceNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Reference)
                    .HasConstraintName("FK__Student__Referen__412EB0B6");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
