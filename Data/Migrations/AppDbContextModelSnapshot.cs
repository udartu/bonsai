﻿// <auto-generated />
using Bonsai.Data;
using Bonsai.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Bonsai.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Bonsai.Data.Models.AccessRule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AllowEditing");

                    b.Property<string>("AppUserId");

                    b.Property<Guid>("PageId");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("PageId");

                    b.HasIndex("UserId");

                    b.ToTable("AccessRules");
                });

            modelBuilder.Entity("Bonsai.Data.Models.AppConfig", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AllowGuests");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Config");
                });

            modelBuilder.Entity("Bonsai.Data.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Bonsai.Data.Models.Changeset", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AffectedDiff")
                        .IsRequired();

                    b.Property<string>("AffectedEntityIds")
                        .IsRequired();

                    b.Property<string>("AppUserId");

                    b.Property<string>("AuthorId")
                        .IsRequired();

                    b.Property<DateTimeOffset>("Date");

                    b.Property<string>("SourceDiff")
                        .IsRequired();

                    b.Property<Guid>("SourceEntityId");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Changes");
                });

            modelBuilder.Entity("Bonsai.Data.Models.Media", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Description");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Title");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.ToTable("Media");
                });

            modelBuilder.Entity("Bonsai.Data.Models.MediaTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Coordinates")
                        .HasMaxLength(100);

                    b.Property<Guid>("MediaId");

                    b.Property<Guid?>("ObjectId");

                    b.Property<string>("ObjectTitle");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("MediaId");

                    b.HasIndex("ObjectId");

                    b.ToTable("MediaTags");
                });

            modelBuilder.Entity("Bonsai.Data.Models.Page", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Facts");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<Guid?>("MainPhotoId");

                    b.Property<int>("PageType");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.HasIndex("MainPhotoId");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("Bonsai.Data.Models.PageExcerpt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BirthDate");

                    b.Property<string>("DeathDate");

                    b.Property<bool?>("Gender");

                    b.Property<string>("Key");

                    b.Property<int>("PageType");

                    b.Property<string>("ShortName");

                    b.Property<string>("Title");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Bonsai.Data.Models.Relation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("DestinationId");

                    b.Property<string>("Duration")
                        .HasMaxLength(30);

                    b.Property<bool>("IsComplementary");

                    b.Property<Guid>("SourceId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.HasIndex("SourceId");

                    b.ToTable("Relations");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Bonsai.Data.Models.AccessRule", b =>
                {
                    b.HasOne("Bonsai.Data.Models.AppUser")
                        .WithMany("AccessRules")
                        .HasForeignKey("AppUserId");

                    b.HasOne("Bonsai.Data.Models.Page", "Page")
                        .WithMany()
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bonsai.Data.Models.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Bonsai.Data.Models.Changeset", b =>
                {
                    b.HasOne("Bonsai.Data.Models.AppUser")
                        .WithMany("Changes")
                        .HasForeignKey("AppUserId");

                    b.HasOne("Bonsai.Data.Models.AppUser", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Bonsai.Data.Models.MediaTag", b =>
                {
                    b.HasOne("Bonsai.Data.Models.Media", "Media")
                        .WithMany("Tags")
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bonsai.Data.Models.Page", "Object")
                        .WithMany("MediaTags")
                        .HasForeignKey("ObjectId");
                });

            modelBuilder.Entity("Bonsai.Data.Models.Page", b =>
                {
                    b.HasOne("Bonsai.Data.Models.Media", "MainPhoto")
                        .WithMany()
                        .HasForeignKey("MainPhotoId");
                });

            modelBuilder.Entity("Bonsai.Data.Models.Relation", b =>
                {
                    b.HasOne("Bonsai.Data.Models.Page", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bonsai.Data.Models.Page", "Source")
                        .WithMany("Relations")
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Bonsai.Data.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Bonsai.Data.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bonsai.Data.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Bonsai.Data.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
