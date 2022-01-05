using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Tiffin.Helpers;

#nullable disable

namespace Tiffin.Models
{
    public partial class tiffinContext : IdentityDbContext<ApplicationUser>
    {
        public tiffinContext()
        {
        }

        public tiffinContext(DbContextOptions<tiffinContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<CancellationStatus> CancellationStatuses { get; set; }
        public virtual DbSet<ContactInfo> ContactInfos { get; set; }
        public virtual DbSet<DayWiseMenu> DayWiseMenus { get; set; }
        public virtual DbSet<DeliveryStatus> DeliveryStatuses { get; set; }
        public virtual DbSet<Duration> Durations { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodType> FoodTypes { get; set; }
        public virtual DbSet<Interval> Intervals { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WeekDay> WeekDays { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=VIPULDABHI\\SQLEXPRESS;Database=tiffin;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Area>(entity =>
            {
                entity.ToTable("Area");

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CancellationStatus>(entity =>
            {
                entity.HasKey(e => e.CancellationId)
                    .HasName("PK__Cancella__6A2D9A3A0A1EBA92");

                entity.ToTable("CancellationStatus");

                entity.Property(e => e.CancellationDate).HasColumnType("date");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Interval)
                    .WithMany(p => p.CancellationStatuses)
                    .HasForeignKey(d => d.IntervalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cancellat__Inter__09A971A2");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.CancellationStatuses)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cancellat__Order__08B54D69");
            });

            modelBuilder.Entity<ContactInfo>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("PK__ContactI__5C66259BF762F400");

                entity.ToTable("ContactInfo");

                entity.Property(e => e.ContactNo)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsSolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.Subject).IsRequired();
            });

            modelBuilder.Entity<DayWiseMenu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DayWiseMenu");

                entity.Property(e => e.FoodName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IntervalName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WeekDayName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeliveryStatus>(entity =>
            {
                entity.HasKey(e => e.DeliveryId)
                    .HasName("PK__Delivery__626D8FCEC18C1AB8");

                entity.ToTable("DeliveryStatus");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Interval)
                    .WithMany(p => p.DeliveryStatuses)
                    .HasForeignKey(d => d.IntervalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DeliveryS__Inter__04E4BC85");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.DeliveryStatuses)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DeliveryS__Order__03F0984C");
            });

            modelBuilder.Entity<Duration>(entity =>
            {
                entity.ToTable("Duration");

                entity.Property(e => e.DurationTime)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.ToTable("Food");

                entity.Property(e => e.FoodName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<FoodType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__FoodType__516F03B51ECC5A66");

                entity.ToTable("FoodType");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Interval>(entity =>
            {
                entity.ToTable("Interval");

                entity.Property(e => e.IntervalName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.Menus)
                    .HasForeignKey(d => d.DayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Menu__DayId__6FE99F9F");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.Menus)
                    .HasForeignKey(d => d.FoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Menu__FoodId__70DDC3D8");

                entity.HasOne(d => d.Interval)
                    .WithMany(p => p.Menus)
                    .HasForeignKey(d => d.IntervalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Menu__IntervalId__71D1E811");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__OrderDet__C3905BCFDA5B6996");

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderPlaceDate).HasColumnType("date");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderDeta__AreaI__7D439ABD");

                entity.HasOne(d => d.Duration)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.DurationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderDeta__Durat__7C4F7684");

                entity.HasOne(d => d.Interval)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.IntervalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderDeta__Inter__7A672E12");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderDeta__TypeI__7B5B524B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderDeta__UserI__797309D9");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__AreaId__75A278F5");
            });

            modelBuilder.Entity<WeekDay>(entity =>
            {
                entity.HasKey(e => e.DayId)
                    .HasName("PK__WeekDays__BF3DD8C572600A8E");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.WeekDayName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
