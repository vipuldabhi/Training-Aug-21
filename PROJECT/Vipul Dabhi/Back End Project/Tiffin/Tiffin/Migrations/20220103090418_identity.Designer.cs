﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tiffin.Models;

namespace Tiffin.Migrations
{
    [DbContext(typeof(tiffinContext))]
    [Migration("20220103090418_identity")]
    partial class identity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Tiffin.Helpers.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Tiffin.Models.Area", b =>
                {
                    b.Property<int>("AreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AreaName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("AreaId");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("Tiffin.Models.CancellationStatus", b =>
                {
                    b.Property<int>("CancellationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CancellationDate")
                        .HasColumnType("date");

                    b.Property<int>("IntervalId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("CancellationId")
                        .HasName("PK__Cancella__6A2D9A3A0A1EBA92");

                    b.HasIndex("IntervalId");

                    b.HasIndex("OrderId");

                    b.ToTable("CancellationStatus");
                });

            modelBuilder.Entity("Tiffin.Models.ContactInfo", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<bool?>("IsSolved")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ContactId")
                        .HasName("PK__ContactI__5C66259BF762F400");

                    b.ToTable("ContactInfo");
                });

            modelBuilder.Entity("Tiffin.Models.DayWiseMenu", b =>
                {
                    b.Property<int>("DayId")
                        .HasColumnType("int");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("IntervalId")
                        .HasColumnType("int");

                    b.Property<string>("IntervalName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("WeekDayName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.ToView("DayWiseMenu");
                });

            modelBuilder.Entity("Tiffin.Models.DeliveryStatus", b =>
                {
                    b.Property<int>("DeliveryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IntervalId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("DeliveryId")
                        .HasName("PK__Delivery__626D8FCEC18C1AB8");

                    b.HasIndex("IntervalId");

                    b.HasIndex("OrderId");

                    b.ToTable("DeliveryStatus");
                });

            modelBuilder.Entity("Tiffin.Models.Duration", b =>
                {
                    b.Property<int>("DurationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DurationTime")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("DurationId");

                    b.ToTable("Duration");
                });

            modelBuilder.Entity("Tiffin.Models.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("FoodId");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("Tiffin.Models.FoodType", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("TypeId")
                        .HasName("PK__FoodType__516F03B51ECC5A66");

                    b.ToTable("FoodType");
                });

            modelBuilder.Entity("Tiffin.Models.Interval", b =>
                {
                    b.Property<int>("IntervalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("IntervalName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("IntervalId");

                    b.ToTable("Interval");
                });

            modelBuilder.Entity("Tiffin.Models.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DayId")
                        .HasColumnType("int");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<int>("IntervalId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("MenuId");

                    b.HasIndex("DayId");

                    b.HasIndex("FoodId");

                    b.HasIndex("IntervalId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Tiffin.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<int>("DurationId")
                        .HasColumnType("int");

                    b.Property<int>("IntervalId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("OrderPlaceDate")
                        .HasColumnType("date");

                    b.Property<string>("PaymentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId")
                        .HasName("PK__OrderDet__C3905BCFDA5B6996");

                    b.HasIndex("AreaId");

                    b.HasIndex("DurationId");

                    b.HasIndex("IntervalId");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Tiffin.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.HasKey("UserId");

                    b.HasIndex("AreaId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Tiffin.Models.WeekDay", b =>
                {
                    b.Property<int>("DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("WeekDayName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("DayId")
                        .HasName("PK__WeekDays__BF3DD8C572600A8E");

                    b.ToTable("WeekDays");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Tiffin.Helpers.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Tiffin.Helpers.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tiffin.Helpers.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Tiffin.Helpers.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Tiffin.Models.CancellationStatus", b =>
                {
                    b.HasOne("Tiffin.Models.Interval", "Interval")
                        .WithMany("CancellationStatuses")
                        .HasForeignKey("IntervalId")
                        .HasConstraintName("FK__Cancellat__Inter__09A971A2")
                        .IsRequired();

                    b.HasOne("Tiffin.Models.OrderDetail", "Order")
                        .WithMany("CancellationStatuses")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK__Cancellat__Order__08B54D69")
                        .IsRequired();

                    b.Navigation("Interval");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Tiffin.Models.DeliveryStatus", b =>
                {
                    b.HasOne("Tiffin.Models.Interval", "Interval")
                        .WithMany("DeliveryStatuses")
                        .HasForeignKey("IntervalId")
                        .HasConstraintName("FK__DeliveryS__Inter__04E4BC85")
                        .IsRequired();

                    b.HasOne("Tiffin.Models.OrderDetail", "Order")
                        .WithMany("DeliveryStatuses")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK__DeliveryS__Order__03F0984C")
                        .IsRequired();

                    b.Navigation("Interval");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Tiffin.Models.Menu", b =>
                {
                    b.HasOne("Tiffin.Models.WeekDay", "Day")
                        .WithMany("Menus")
                        .HasForeignKey("DayId")
                        .HasConstraintName("FK__Menu__DayId__6FE99F9F")
                        .IsRequired();

                    b.HasOne("Tiffin.Models.Food", "Food")
                        .WithMany("Menus")
                        .HasForeignKey("FoodId")
                        .HasConstraintName("FK__Menu__FoodId__70DDC3D8")
                        .IsRequired();

                    b.HasOne("Tiffin.Models.Interval", "Interval")
                        .WithMany("Menus")
                        .HasForeignKey("IntervalId")
                        .HasConstraintName("FK__Menu__IntervalId__71D1E811")
                        .IsRequired();

                    b.Navigation("Day");

                    b.Navigation("Food");

                    b.Navigation("Interval");
                });

            modelBuilder.Entity("Tiffin.Models.OrderDetail", b =>
                {
                    b.HasOne("Tiffin.Models.Area", "Area")
                        .WithMany("OrderDetails")
                        .HasForeignKey("AreaId")
                        .HasConstraintName("FK__OrderDeta__AreaI__7D439ABD")
                        .IsRequired();

                    b.HasOne("Tiffin.Models.Duration", "Duration")
                        .WithMany("OrderDetails")
                        .HasForeignKey("DurationId")
                        .HasConstraintName("FK__OrderDeta__Durat__7C4F7684")
                        .IsRequired();

                    b.HasOne("Tiffin.Models.Interval", "Interval")
                        .WithMany("OrderDetails")
                        .HasForeignKey("IntervalId")
                        .HasConstraintName("FK__OrderDeta__Inter__7A672E12")
                        .IsRequired();

                    b.HasOne("Tiffin.Models.FoodType", "Type")
                        .WithMany("OrderDetails")
                        .HasForeignKey("TypeId")
                        .HasConstraintName("FK__OrderDeta__TypeI__7B5B524B")
                        .IsRequired();

                    b.HasOne("Tiffin.Models.User", "User")
                        .WithMany("OrderDetails")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__OrderDeta__UserI__797309D9")
                        .IsRequired();

                    b.Navigation("Area");

                    b.Navigation("Duration");

                    b.Navigation("Interval");

                    b.Navigation("Type");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Tiffin.Models.User", b =>
                {
                    b.HasOne("Tiffin.Models.Area", "Area")
                        .WithMany("Users")
                        .HasForeignKey("AreaId")
                        .HasConstraintName("FK__Users__AreaId__75A278F5")
                        .IsRequired();

                    b.Navigation("Area");
                });

            modelBuilder.Entity("Tiffin.Models.Area", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Tiffin.Models.Duration", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Tiffin.Models.Food", b =>
                {
                    b.Navigation("Menus");
                });

            modelBuilder.Entity("Tiffin.Models.FoodType", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Tiffin.Models.Interval", b =>
                {
                    b.Navigation("CancellationStatuses");

                    b.Navigation("DeliveryStatuses");

                    b.Navigation("Menus");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Tiffin.Models.OrderDetail", b =>
                {
                    b.Navigation("CancellationStatuses");

                    b.Navigation("DeliveryStatuses");
                });

            modelBuilder.Entity("Tiffin.Models.User", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Tiffin.Models.WeekDay", b =>
                {
                    b.Navigation("Menus");
                });
#pragma warning restore 612, 618
        }
    }
}
