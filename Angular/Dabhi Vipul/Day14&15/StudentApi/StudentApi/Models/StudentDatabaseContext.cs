using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StudentApi.Models
{
    public partial class StudentDatabaseContext : DbContext
    {
        public StudentDatabaseContext()
        {
        }

        public StudentDatabaseContext(DbContextOptions<StudentDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Emergency> Emergencies { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=VIPULDABHI\\SQLEXPRESS;Database=StudentDatabase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emergency>(entity =>
            {
                entity.ToTable("Emergency");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Relation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("relation");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Emergencies)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Emergency__Stude__72C60C4A");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.Dateofbirth)
                    .HasColumnType("datetime")
                    .HasColumnName("dateofbirth");

                entity.Property(e => e.Fatherdesignation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fatherdesignation");

                entity.Property(e => e.Fatheremail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fatheremail");

                entity.Property(e => e.Fatherfirstname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fatherfirstname");

                entity.Property(e => e.Fatherlastname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fatherlastname");

                entity.Property(e => e.Fathermiddlename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fathermiddlename");

                entity.Property(e => e.Fatherphone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fatherphone");

                entity.Property(e => e.Fatherprofession)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fatherprofession");

                entity.Property(e => e.Fatherqualification)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fatherqualification");

                entity.Property(e => e.Firstlanguage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("firstlanguage");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("firstname");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastname");

                entity.Property(e => e.Middlename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("middlename");

                entity.Property(e => e.Motherdesignation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("motherdesignation");

                entity.Property(e => e.Motheremail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("motheremail");

                entity.Property(e => e.Motherfirstname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("motherfirstname");

                entity.Property(e => e.Motherlastname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("motherlastname");

                entity.Property(e => e.Mothermiddlename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mothermiddlename");

                entity.Property(e => e.Motherphone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("motherphone");

                entity.Property(e => e.Motherprofession)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("motherprofession");

                entity.Property(e => e.Motherqualification)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("motherqualification");

                entity.Property(e => e.Pin).HasColumnName("pin");

                entity.Property(e => e.Placeofbirth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("placeofbirth");

                entity.Property(e => e.Refaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("refaddress");

                entity.Property(e => e.Refdetails)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("refdetails");

                entity.Property(e => e.Refthrough)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("refthrough");

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("state");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
