using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace E_Tiffin_Service.Models
{
    public partial class ETiffinContext : IdentityDbContext<ApplicationUser>
    {
        public ETiffinContext()
        {
        }

        public ETiffinContext(DbContextOptions<ETiffinContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        //public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        //public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        //public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        //public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        //public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        //public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<CancellationStatus> CancellationStatuses { get; set; }
        public virtual DbSet<CancelledOrder> CancelledOrders { get; set; }
        public virtual DbSet<ContactInfo> ContactInfos { get; set; }
        public virtual DbSet<DeliveryStatus> DeliveryStatuses { get; set; }
        public virtual DbSet<FridayDinnerMenu> FridayDinnerMenus { get; set; }
        public virtual DbSet<FridayLunchMenu> FridayLunchMenus { get; set; }
        public virtual DbSet<MondayDinnerMenu> MondayDinnerMenus { get; set; }
        public virtual DbSet<MondayLunchMenu> MondayLunchMenus { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public virtual DbSet<PendingPayment> PendingPayments { get; set; }
        public virtual DbSet<SaturdayDinnerMenu> SaturdayDinnerMenus { get; set; }
        public virtual DbSet<SaturdayLunchMenu> SaturdayLunchMenus { get; set; }
        public virtual DbSet<SundayDinnerMenu> SundayDinnerMenus { get; set; }
        public virtual DbSet<SundayLunchMenu> SundayLunchMenus { get; set; }
        public virtual DbSet<ThursdayDinnerMenu> ThursdayDinnerMenus { get; set; }
        public virtual DbSet<ThursdayLunchMenu> ThursdayLunchMenus { get; set; }
        public virtual DbSet<TuesdayDinnerMenu> TuesdayDinnerMenus { get; set; }
        public virtual DbSet<TuesdayLunchMenu> TuesdayLunchMenus { get; set; }
        public virtual DbSet<WednesdayDinnerMenu> WednesdayDinnerMenus { get; set; }
        public virtual DbSet<WednesdayLunchMenu> WednesdayLunchMenus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=VIPULDABHI\\SQLEXPRESS;Database=ETiffin;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<CancellationStatus>(entity =>
            {
                entity.HasKey(e => e.CancellationId)
                    .HasName("PK__Cancella__6A2D9A3AFB2310F1");

                entity.ToTable("CancellationStatus");

                entity.Property(e => e.CancellationId).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Dinner)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.Lunch)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.CancellationStatuses)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__Cancellat__Order__1F98B2C1");
            });

            modelBuilder.Entity<CancelledOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CancelledOrders");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContactInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContactInfo");

                entity.Property(e => e.ContactId).ValueGeneratedOnAdd();

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

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeliveryStatus>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Delivery__C3905BCF5E05AFF2");

                entity.ToTable("DeliveryStatus");

                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Dinner)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.Lunch)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.DeliveryStatus)
                    .HasForeignKey<DeliveryStatus>(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DeliveryS__Order__1AD3FDA4");
            });

            modelBuilder.Entity<FridayDinnerMenu>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__FridayDi__727E838B038E88E2");

                entity.ToTable("FridayDinnerMenu");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FridayLunchMenu>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__FridayLu__727E838B814023EC");

                entity.ToTable("FridayLunchMenu");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MondayDinnerMenu>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__MondayDi__727E838B495B93A1");

                entity.ToTable("MondayDinnerMenu");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MondayLunchMenu>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__MondayLu__727E838BE8C27D70");

                entity.ToTable("MondayLunchMenu");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__OrderDet__C3905BCF4CFB325E");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TiffinPlan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TiffinTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TiffinType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentStatus>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PK__PaymentS__9B556A3844F7F24D");

                entity.ToTable("PaymentStatus");

                entity.Property(e => e.PaymentId).ValueGeneratedNever();

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.PaymentStatuses)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__PaymentSt__Order__2A164134");
            });

            modelBuilder.Entity<PendingPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PendingPayment");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaturdayDinnerMenu>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__Saturday__727E838B12FD2CD4");

                entity.ToTable("SaturdayDinnerMenu");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SaturdayLunchMenu>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__Saturday__727E838B1842E485");

                entity.ToTable("SaturdayLunchMenu");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SundayDinnerMenu>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__SundayDi__727E838BD146E777");

                entity.ToTable("SundayDinnerMenu");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SundayLunchMenu>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__SundayLu__727E838BBCD08622");

                entity.ToTable("SundayLunchMenu");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ThursdayDinnerMenu>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__Thursday__727E838B1B797EB4");

                entity.ToTable("ThursdayDinnerMenu");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ThursdayLunchMenu>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__Thursday__727E838BF159AD09");

                entity.ToTable("ThursdayLunchMenu");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TuesdayDinnerMenu>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__TuesdayD__727E838B3517EA1C");

                entity.ToTable("TuesdayDinnerMenu");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TuesdayLunchMenu>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__TuesdayL__727E838B75CCF279");

                entity.ToTable("TuesdayLunchMenu");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WednesdayDinnerMenu>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__Wednesda__727E838B5A71795B");

                entity.ToTable("WednesdayDinnerMenu");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WednesdayLunchMenu>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__Wednesda__727E838B01B2AF9A");

                entity.ToTable("WednesdayLunchMenu");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
