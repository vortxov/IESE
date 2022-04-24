using IESE.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IESE.Domain
{
    public class AppDbContext : IdentityDbContext<ApplicationUser> //Таблицы для бд
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<WordDocument> WordDocuments { get; set; }
        public DbSet<WordTemplate> WordTemplates { get; set; }
        public DbSet<DocumentCategory> DocumentCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) //Функция для стандартных строк в бд, если их нет то создаст если есть то ничего не сделает
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "eb91da24-af76-4b5c-ad48-cce1a100bb31",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "832095e2-5c23-4da1-a83f-b7800e8473a6",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@email.com",
                NormalizedEmail = "ADMIN@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "admin"),
                SecurityStamp = string.Empty
            });





            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "836d1908-8acb-464e-8d76-426153642557",
                Name = "user",
                NormalizedName = "USER"
            });

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                UserName = "user",
                NormalizedUserName = "USER",
                Email = "user@email.com",
                NormalizedEmail = "USER@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "user"),
                SecurityStamp = string.Empty
            });






            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "a9f1088f-76ba-4052-8f77-d3572e0ffc90",
                Name = "otdelcadrov",
                NormalizedName = "OTDELCADROV"
            });

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                UserName = "otdelcadrov",
                NormalizedUserName = "OTDELCADROV",
                Email = "otdelcadrov@email.com",
                NormalizedEmail = "OTDELCADROV@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "otdelcadrov"),
                SecurityStamp = string.Empty
            });




            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "392fb190-6b32-4623-9e6f-adc884524345",
                Name = "teacher",
                NormalizedName = "TEACHER"
            });



            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "05301c29-f5f6-49a9-b967-25025c22922e",
                UserName = "teacher",
                NormalizedUserName = "TEACHER",
                Email = "teacher@email.com",
                NormalizedEmail = "TEACHER@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "teacher"),
                SecurityStamp = string.Empty
            });





            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "a8f8feb0-be4a-4637-8634-4d46d4b06c0d",
                Name = "teacheruser",
                NormalizedName = "TEACHERUSER"
            });


            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                UserName = "teacheruser",
                NormalizedUserName = "TEACHERUSER",
                Email = "teacheruser@email.com",
                NormalizedEmail = "TEACHERUSER@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "teacheruser"),
                SecurityStamp = string.Empty
            });



            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "eb91da24-af76-4b5c-ad48-cce1a100bb31",
                UserId = "832095e2-5c23-4da1-a83f-b7800e8473a6"
            });



            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "836d1908-8acb-464e-8d76-426153642557",
                UserId = "f757a680-51b0-4df8-89f9-c19ed6c08d85"
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "a9f1088f-76ba-4052-8f77-d3572e0ffc90",
                UserId = "f07b07c6-f9f2-43cf-b4db-14903b8215e8"
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "392fb190-6b32-4623-9e6f-adc884524345",
                UserId = "05301c29-f5f6-49a9-b967-25025c22922e"
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "a8f8feb0-be4a-4637-8634-4d46d4b06c0d",
                UserId = "83e5cde4-3926-4d97-a42c-ecbcfd5f051b"
            });
        }
    }
}
