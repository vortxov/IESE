﻿// <auto-generated />
using System;
using IESE.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IESE.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220511150047_userup6")]
    partial class userup6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DocumentCategoryWordDocument", b =>
                {
                    b.Property<Guid>("CategoriesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DocumentsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CategoriesId", "DocumentsId");

                    b.HasIndex("DocumentsId");

                    b.ToTable("DocumentCategoryWordDocument");
                });

            modelBuilder.Entity("IESE.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Course")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Faculty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormOfEducation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Group")
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

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
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

                    b.HasData(
                        new
                        {
                            Id = "832095e2-5c23-4da1-a83f-b7800e8473a6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "63a08689-94fa-41fe-8024-c03f2469c914",
                            Email = "admin@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEL8a73/sIhuXeRCdAYi8jEsr0kjfXvrabzeVE5EdKSsObBphqYmCZBa1bbtFzsXXjg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9a16aea0-314a-4267-9832-113bfe6b203b",
                            Email = "user@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@EMAIL.COM",
                            NormalizedUserName = "USER",
                            PasswordHash = "AQAAAAEAACcQAAAAECxcUlXGcEYNbDdmI4IXx2ej56XP/rfjRzsFZ4sM2zSzHX8Fjq68a5U9udzw5URpNQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "user"
                        },
                        new
                        {
                            Id = "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "53020d89-fc95-4a7b-a272-6f22320c7aff",
                            Email = "otdelcadrov@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "OTDELCADROV@EMAIL.COM",
                            NormalizedUserName = "OTDELCADROV",
                            PasswordHash = "AQAAAAEAACcQAAAAELRCE9+Fma+04yddrTe30vsS+2BzrnmtoGwTq90H4/YRKi3V4554fVbIQ+Z0MTbX1A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "otdelcadrov"
                        },
                        new
                        {
                            Id = "05301c29-f5f6-49a9-b967-25025c22922e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0c46c55c-403f-41b1-8e59-d2a2db143fc6",
                            Email = "teacher@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "TEACHER@EMAIL.COM",
                            NormalizedUserName = "TEACHER",
                            PasswordHash = "AQAAAAEAACcQAAAAEHF+L5G6sgbZpdjMJOcjyC9TPLm8lOe7FdAFPaUd5aYjmyDz3VqqguTUj9vf6aEZYQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "teacher"
                        },
                        new
                        {
                            Id = "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "69565c8a-47e2-42f8-952f-abb85127ff14",
                            Email = "teacheruser@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "TEACHERUSER@EMAIL.COM",
                            NormalizedUserName = "TEACHERUSER",
                            PasswordHash = "AQAAAAEAACcQAAAAECd2wX97XsXlUfk3DSe2xE5zaALCiu3FeoS6g2cay0vPe8zuyX5RUSllo7/lPPtaow==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "teacheruser"
                        });
                });

            modelBuilder.Entity("IESE.Domain.Entities.DocumentCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NameCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DocumentCategories");
                });

            modelBuilder.Entity("IESE.Domain.Entities.WordDocument", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathHTM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathPDF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WordDocuments");
                });

            modelBuilder.Entity("IESE.Domain.Entities.WordTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Template")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WordTemplates");
                });

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

                    b.Property<Guid?>("WordDocumentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.HasIndex("WordDocumentId");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "eb91da24-af76-4b5c-ad48-cce1a100bb31",
                            ConcurrencyStamp = "a83a01bb-a8c7-4ae0-8cfd-aaeb2128c20e",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "836d1908-8acb-464e-8d76-426153642557",
                            ConcurrencyStamp = "351f6a5b-811d-45ec-bc7d-07c1bd170d88",
                            Name = "user",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "a9f1088f-76ba-4052-8f77-d3572e0ffc90",
                            ConcurrencyStamp = "c6d19414-df10-4f08-b623-72c8a39f1bf0",
                            Name = "otdelcadrov",
                            NormalizedName = "OTDELCADROV"
                        },
                        new
                        {
                            Id = "392fb190-6b32-4623-9e6f-adc884524345",
                            ConcurrencyStamp = "252e09c8-274d-4098-b374-acc09e6d0866",
                            Name = "teacher",
                            NormalizedName = "TEACHER"
                        },
                        new
                        {
                            Id = "a8f8feb0-be4a-4637-8634-4d46d4b06c0d",
                            ConcurrencyStamp = "39a2ded2-d6c8-45d7-ae85-85fcbd5a7715",
                            Name = "teacheruser",
                            NormalizedName = "TEACHERUSER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.HasData(
                        new
                        {
                            UserId = "832095e2-5c23-4da1-a83f-b7800e8473a6",
                            RoleId = "eb91da24-af76-4b5c-ad48-cce1a100bb31"
                        },
                        new
                        {
                            UserId = "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                            RoleId = "836d1908-8acb-464e-8d76-426153642557"
                        },
                        new
                        {
                            UserId = "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                            RoleId = "a9f1088f-76ba-4052-8f77-d3572e0ffc90"
                        },
                        new
                        {
                            UserId = "05301c29-f5f6-49a9-b967-25025c22922e",
                            RoleId = "392fb190-6b32-4623-9e6f-adc884524345"
                        },
                        new
                        {
                            UserId = "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                            RoleId = "a8f8feb0-be4a-4637-8634-4d46d4b06c0d"
                        });
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

            modelBuilder.Entity("DocumentCategoryWordDocument", b =>
                {
                    b.HasOne("IESE.Domain.Entities.DocumentCategory", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IESE.Domain.Entities.WordDocument", null)
                        .WithMany()
                        .HasForeignKey("DocumentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.HasOne("IESE.Domain.Entities.WordDocument", null)
                        .WithMany("Roles")
                        .HasForeignKey("WordDocumentId");
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
                    b.HasOne("IESE.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("IESE.Domain.Entities.ApplicationUser", null)
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

                    b.HasOne("IESE.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("IESE.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IESE.Domain.Entities.WordDocument", b =>
                {
                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
