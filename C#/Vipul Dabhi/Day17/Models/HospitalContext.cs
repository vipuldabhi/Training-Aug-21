using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Day17.Models
{
    public partial class HospitalContext : IdentityDbContext<ApplicationUser>
    {
        public HospitalContext()
        {
        }

        public HospitalContext(DbContextOptions<HospitalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Assistance> Assistances { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<DoctorWithPatient> DoctorWithPatients { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientTakesMadicine> PatientTakesMadicines { get; set; }
        public virtual DbSet<PatientWithTreatementDetail> PatientWithTreatementDetails { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=VIPULDABHI\\SQLEXPRESS;Database=Hospital;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Assistance>(entity =>
            {
                entity.ToTable("Assistance");

                entity.Property(e => e.AssistanceId)
                    .ValueGeneratedNever()
                    .HasColumnName("AssistanceID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.WorkUnderNavigation)
                    .WithMany(p => p.Assistances)
                    .HasForeignKey(d => d.WorkUnder)
                    .HasConstraintName("FK__Assistanc__WorkU__4AB81AF0");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.Property(e => e.DoctorId)
                    .ValueGeneratedNever()
                    .HasColumnName("DoctorID");

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.DepartmentNavigation)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.Department)
                    .HasConstraintName("FK__Doctors__Departm__3A81B327");
            });

            modelBuilder.Entity<DoctorWithPatient>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DoctorWithPatient");

                entity.Property(e => e.AssistantId).HasColumnName("AssistantID");

                entity.Property(e => e.DoctorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TreatementDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Drug>(entity =>
            {
                entity.Property(e => e.DrugId)
                    .ValueGeneratedNever()
                    .HasColumnName("DrugID");

                entity.Property(e => e.DrugName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient");

                entity.Property(e => e.PatientId)
                    .ValueGeneratedNever()
                    .HasColumnName("PatientID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatientTakesMadicine>(entity =>
            {
                entity.ToTable("PatientTakesMadicine");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.AssistanceNavigation)
                    .WithMany(p => p.PatientTakesMadicines)
                    .HasForeignKey(d => d.Assistance)
                    .HasConstraintName("FK__PatientTa__Assis__5441852A");

                entity.HasOne(d => d.DrugNavigation)
                    .WithMany(p => p.PatientTakesMadicines)
                    .HasForeignKey(d => d.Drug)
                    .HasConstraintName("FK__PatientTak__Drug__534D60F1");

                entity.HasOne(d => d.PatientNavigation)
                    .WithMany(p => p.PatientTakesMadicines)
                    .HasForeignKey(d => d.Patient)
                    .HasConstraintName("FK__PatientTa__EndDa__52593CB8");
            });

            modelBuilder.Entity<PatientWithTreatementDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PatientWithTreatementDetails");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.TreatementDate).HasColumnType("datetime");

                entity.Property(e => e.TreatementId).HasColumnName("TreatementID");
            });

            modelBuilder.Entity<Treatment>(entity =>
            {
                entity.HasKey(e => e.TreatementId)
                    .HasName("PK__Treatmen__ED3C5DB84EA044D4");

                entity.ToTable("Treatment");

                entity.Property(e => e.TreatementId)
                    .ValueGeneratedNever()
                    .HasColumnName("TreatementID");

                entity.Property(e => e.TreatementDate).HasColumnType("datetime");

                entity.HasOne(d => d.AssistanceNavigation)
                    .WithMany(p => p.Treatments)
                    .HasForeignKey(d => d.Assistance)
                    .HasConstraintName("FK__Treatment__Assis__4F7CD00D");

                entity.HasOne(d => d.DoctorNavigation)
                    .WithMany(p => p.Treatments)
                    .HasForeignKey(d => d.Doctor)
                    .HasConstraintName("FK__Treatment__Docto__4E88ABD4");

                entity.HasOne(d => d.PatientNavigation)
                    .WithMany(p => p.Treatments)
                    .HasForeignKey(d => d.Patient)
                    .HasConstraintName("FK__Treatment__Patie__4D94879B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
