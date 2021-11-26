using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Day11.Models
{
    public partial class HospitalContext : DbContext
    {
        public HospitalContext()
        {
        }

        public HospitalContext(DbContextOptions<HospitalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Assistance> Assistance { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<DoctorWithPatient> DoctorWithPatient { get; set; }
        public virtual DbSet<Doctors> Doctors { get; set; }
        public virtual DbSet<Drugs> Drugs { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientTakesMadicine> PatientTakesMadicine { get; set; }
        public virtual DbSet<PatientWithTreatementDetails> PatientWithTreatementDetails { get; set; }
        public virtual DbSet<Treatment> Treatment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=VIPULDABHI\\SQLEXPRESS;Database=Hospital;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assistance>(entity =>
            {
                entity.Property(e => e.AssistanceId)
                    .HasColumnName("AssistanceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.WorkUnderNavigation)
                    .WithMany(p => p.Assistance)
                    .HasForeignKey(d => d.WorkUnder)
                    .HasConstraintName("FK__Assistanc__WorkU__4AB81AF0");
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK__Departme__B2079BCDFFE242E4");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
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

            modelBuilder.Entity<Doctors>(entity =>
            {
                entity.HasKey(e => e.DoctorId)
                    .HasName("PK__Doctors__2DC00EDF4FB7BAC6");

                entity.Property(e => e.DoctorId)
                    .HasColumnName("DoctorID")
                    .ValueGeneratedNever();

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

            modelBuilder.Entity<Drugs>(entity =>
            {
                entity.HasKey(e => e.DrugId)
                    .HasName("PK__Drugs__908D66F67BC117B1");

                entity.Property(e => e.DrugId)
                    .HasColumnName("DrugID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DrugName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.PatientId)
                    .HasColumnName("PatientID")
                    .ValueGeneratedNever();

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
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.AssistanceNavigation)
                    .WithMany(p => p.PatientTakesMadicine)
                    .HasForeignKey(d => d.Assistance)
                    .HasConstraintName("FK__PatientTa__Assis__5441852A");

                entity.HasOne(d => d.DrugNavigation)
                    .WithMany(p => p.PatientTakesMadicine)
                    .HasForeignKey(d => d.Drug)
                    .HasConstraintName("FK__PatientTak__Drug__534D60F1");

                entity.HasOne(d => d.PatientNavigation)
                    .WithMany(p => p.PatientTakesMadicine)
                    .HasForeignKey(d => d.Patient)
                    .HasConstraintName("FK__PatientTa__EndDa__52593CB8");
            });

            modelBuilder.Entity<PatientWithTreatementDetails>(entity =>
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

                entity.Property(e => e.TreatementId)
                    .HasColumnName("TreatementID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TreatementDate).HasColumnType("datetime");

                entity.HasOne(d => d.AssistanceNavigation)
                    .WithMany(p => p.Treatment)
                    .HasForeignKey(d => d.Assistance)
                    .HasConstraintName("FK__Treatment__Assis__4F7CD00D");

                entity.HasOne(d => d.DoctorNavigation)
                    .WithMany(p => p.Treatment)
                    .HasForeignKey(d => d.Doctor)
                    .HasConstraintName("FK__Treatment__Docto__4E88ABD4");

                entity.HasOne(d => d.PatientNavigation)
                    .WithMany(p => p.Treatment)
                    .HasForeignKey(d => d.Patient)
                    .HasConstraintName("FK__Treatment__Patie__4D94879B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
