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
        //public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        //public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        //public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        //public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        //public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        //public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        //public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<AvgRating> AvgRatings { get; set; }
        public virtual DbSet<CancellationStatus> CancellationStatuses { get; set; }
        public virtual DbSet<ContactInfo> ContactInfos { get; set; }
        public virtual DbSet<DayWiseMenu> DayWiseMenus { get; set; }
        public virtual DbSet<DeliveryBoy> DeliveryBoys { get; set; }
        public virtual DbSet<DeliveryCharge> DeliveryCharges { get; set; }
        public virtual DbSet<DeliveryStatus> DeliveryStatuses { get; set; }
        public virtual DbSet<Duration> Durations { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodType> FoodTypes { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Interval> Intervals { get; set; }
        public virtual DbSet<MealCharge> MealCharges { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<TotalRevenue> TotalRevenues { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WeekDay> WeekDays { get; set; }
        public virtual DbSet<RevenueFromOrder> RevenueFromOrder { get; set; }


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

            modelBuilder.Entity<AvgRating>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AvgRatings");

                entity.Property(e => e.AvgRating1).HasColumnName("AvgRating");
            });

            modelBuilder.Entity<RevenueFromOrder>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<CancellationStatus>(entity =>
            {
                entity.HasKey(e => e.CancellationId)
                    .HasName("PK__Cancella__6A2D9A3A0A1EBA92");

                entity.ToTable("CancellationStatus");

                entity.HasIndex(e => e.IntervalId, "IX_CancellationStatus_IntervalId");

                entity.HasIndex(e => e.OrderId, "IX_CancellationStatus_OrderId");

                entity.Property(e => e.CancellationDate).HasColumnType("date");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

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

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(100);
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

                entity.Property(e => e.RestaurantName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.WeekDayName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeliveryBoy>(entity =>
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

                entity.HasOne(d => d.AssignedArea)
                    .WithMany(p => p.DeliveryBoys)
                    .HasForeignKey(d => d.AssignedAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DeliveryB__Assig__0880433F");
            });

            modelBuilder.Entity<DeliveryCharge>(entity =>
            {
                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Duration)
                    .WithMany(p => p.DeliveryCharges)
                    .HasForeignKey(d => d.DurationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DeliveryC__Durat__0C50D423");
            });

            modelBuilder.Entity<DeliveryStatus>(entity =>
            {
                entity.HasKey(e => e.DeliveryId)
                    .HasName("PK__Delivery__626D8FCEC18C1AB8");

                entity.ToTable("DeliveryStatus");

                entity.HasIndex(e => e.IntervalId, "IX_DeliveryStatus_IntervalId");

                entity.HasIndex(e => e.OrderId, "IX_DeliveryStatus_OrderId");

                entity.Property(e => e.DeliveryDate).HasColumnType("date");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

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

            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.ImageName).IsRequired();

                entity.Property(e => e.ImageUrl).IsRequired();
            });

            modelBuilder.Entity<Interval>(entity =>
            {
                entity.ToTable("Interval");

                entity.Property(e => e.IntervalName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");
            });

            modelBuilder.Entity<MealCharge>(entity =>
            {
                entity.HasKey(e => e.ChargeId);

                entity.HasIndex(e => e.IntervalId, "IX_MealCharges_IntervalId");

                entity.HasIndex(e => e.RestaurantsId, "IX_MealCharges_RestaurantsId");

                entity.HasOne(d => d.Interval)
                    .WithMany(p => p.MealCharges)
                    .HasForeignKey(d => d.IntervalId);

                entity.HasOne(d => d.Restaurants)
                    .WithMany(p => p.MealCharges)
                    .HasForeignKey(d => d.RestaurantsId);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu");

                entity.HasIndex(e => e.DayId, "IX_Menu_DayId");

                entity.HasIndex(e => e.FoodId, "IX_Menu_FoodId");

                entity.HasIndex(e => e.IntervalId, "IX_Menu_IntervalId");

                entity.HasIndex(e => e.RestaurantsId, "IX_Menu_RestaurantsId");

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

                entity.HasOne(d => d.Restaurants)
                    .WithMany(p => p.Menus)
                    .HasForeignKey(d => d.RestaurantsId);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__OrderDet__C3905BCFDA5B6996");

                entity.HasIndex(e => e.AreaId, "IX_OrderDetails_AreaId");

                entity.HasIndex(e => e.DurationId, "IX_OrderDetails_DurationId");

                entity.HasIndex(e => e.IntervalId, "IX_OrderDetails_IntervalId");

                entity.HasIndex(e => e.RestaurantsId, "IX_OrderDetails_RestaurantsId");

                entity.HasIndex(e => e.TypeId, "IX_OrderDetails_TypeId");

                entity.HasIndex(e => e.UserId, "IX_OrderDetails_UserId");

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderPlaceDate).HasColumnType("date");

                entity.Property(e => e.PaymentId).IsRequired();

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

                entity.HasOne(d => d.Restaurants)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.RestaurantsId);

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

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.HasKey(e => e.RatindId)
                    .HasName("PK__Ratings__E0C0C782D9BE4E36");

                entity.Property(e => e.Rating1).HasColumnName("Rating");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ratings__Restaur__681373AD");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ratings__UserId__690797E6");
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.Property(e => e.RestaurantName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Restaurants)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK__Restauran__AreaI__74794A92");
            });

            modelBuilder.Entity<TotalRevenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TotalRevenue");

                entity.Property(e => e.TotalRevenue1).HasColumnName("TotalRevenue");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.AreaId, "IX_Users_AreaId");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

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
