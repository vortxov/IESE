using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IESE.Migrations
{
    public partial class listuser3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "44546e06-8719-4ad8-b88a-f271ae9d6eab", "3b62472e-4f66-49fa-a20f-e7685b9565d8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "44546e05-8719-4ad8-b88a-f271ae9d6eab", "3b62472e-4f66-49fa-a20f-e7685b9565d9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e05-8719-4ad8-b88a-f271ae9d6eab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "eb91da24-af76-4b5c-ad48-cce1a100bb31", "8ab65d4c-f01c-442f-bfd6-282d90853cdf", "admin", "ADMIN" },
                    { "836d1908-8acb-464e-8d76-426153642557", "e57bdd23-c306-434a-ab04-56a27a2bc738", "user", "USER" },
                    { "a9f1088f-76ba-4052-8f77-d3572e0ffc90", "3d321542-53c6-4100-a7c1-d204020822c0", "otdelcadrov", "OTDELCADROV" },
                    { "392fb190-6b32-4623-9e6f-adc884524345", "3f95924f-5941-435b-9f20-3041ed4afd20", "teacher", "TEACHER" },
                    { "a8f8feb0-be4a-4637-8634-4d46d4b06c0d", "248ae717-b69e-49c5-b570-1c7f73f733bb", "teacheruser", "TEACHERUSER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Course", "DateEnd", "Email", "EmailConfirmed", "Faculty", "Firstname", "FormOfEducation", "Group", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Patronymic", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialization", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "832095e2-5c23-4da1-a83f-b7800e8473a6", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c0bc231f-eba5-4fba-8b33-57d0493cd6f1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@email.com", true, null, null, null, null, false, null, "ADMIN@EMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEA8nETcQX/aG8DlvxF+NIFMUevTLMb26rwl4g1vHbcb17P5t8WGhCv1nkaarRf598A==", null, null, false, "", null, null, false, "admin" },
                    { "f757a680-51b0-4df8-89f9-c19ed6c08d85", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6b59720f-602c-4146-b55d-dc7d3e701c79", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@email.com", true, null, null, null, null, false, null, "USER@EMAIL.COM", "USER", "AQAAAAEAACcQAAAAEPpgThVjPGGelOly7z2HnQD+cf8B3BEsSpHFer50adb+FGbte+Rd2MF4qMpZeWgshw==", null, null, false, "", null, null, false, "user" },
                    { "f07b07c6-f9f2-43cf-b4db-14903b8215e8", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "08debfd5-585a-45d1-8f68-9da4ad296672", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "otdelcadrov@email.com", true, null, null, null, null, false, null, "OTDELCADROV@EMAIL.COM", "OTDELCADROV", "AQAAAAEAACcQAAAAECTbNnB9cEBenDozZ3NRYtqXqeY72uJYI6NjQ/9gBtX6Nh+vDf1lYmEdFQRcRyYQ+g==", null, null, false, "", null, null, false, "otdelcadrov" },
                    { "05301c29-f5f6-49a9-b967-25025c22922e", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9ef019cd-9996-4cab-825f-91ab94916fd1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "teacher@email.com", true, null, null, null, null, false, null, "TEACHER@EMAIL.COM", "TEACHER", "AQAAAAEAACcQAAAAEH2wiSczXKzvviUZoK5+nsbPjqIvquHW0eydIMtYcChUcaTXshVDf+lNd/qTDMueWQ==", null, null, false, "", null, null, false, "teacher" },
                    { "83e5cde4-3926-4d97-a42c-ecbcfd5f051b", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "799546d0-8dd8-494c-b450-2713b6e2c6bc", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "teacheruser@email.com", true, null, null, null, null, false, null, "TEACHERUSER@EMAIL.COM", "TEACHERUSER", "AQAAAAEAACcQAAAAELVG0+DOLhHbtU3bvgF0yHR9NbYvi16dsKF83OHF5sSXLpTfukQtalXwCwt1gaWW4A==", null, null, false, "", null, null, false, "teacheruser" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "eb91da24-af76-4b5c-ad48-cce1a100bb31", "832095e2-5c23-4da1-a83f-b7800e8473a6" },
                    { "836d1908-8acb-464e-8d76-426153642557", "f757a680-51b0-4df8-89f9-c19ed6c08d85" },
                    { "a9f1088f-76ba-4052-8f77-d3572e0ffc90", "f07b07c6-f9f2-43cf-b4db-14903b8215e8" },
                    { "392fb190-6b32-4623-9e6f-adc884524345", "05301c29-f5f6-49a9-b967-25025c22922e" },
                    { "a8f8feb0-be4a-4637-8634-4d46d4b06c0d", "83e5cde4-3926-4d97-a42c-ecbcfd5f051b" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "392fb190-6b32-4623-9e6f-adc884524345", "05301c29-f5f6-49a9-b967-25025c22922e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eb91da24-af76-4b5c-ad48-cce1a100bb31", "832095e2-5c23-4da1-a83f-b7800e8473a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a8f8feb0-be4a-4637-8634-4d46d4b06c0d", "83e5cde4-3926-4d97-a42c-ecbcfd5f051b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a9f1088f-76ba-4052-8f77-d3572e0ffc90", "f07b07c6-f9f2-43cf-b4db-14903b8215e8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "836d1908-8acb-464e-8d76-426153642557", "f757a680-51b0-4df8-89f9-c19ed6c08d85" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "392fb190-6b32-4623-9e6f-adc884524345");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "836d1908-8acb-464e-8d76-426153642557");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8f8feb0-be4a-4637-8634-4d46d4b06c0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f1088f-76ba-4052-8f77-d3572e0ffc90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb91da24-af76-4b5c-ad48-cce1a100bb31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05301c29-f5f6-49a9-b967-25025c22922e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832095e2-5c23-4da1-a83f-b7800e8473a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83e5cde4-3926-4d97-a42c-ecbcfd5f051b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f07b07c6-f9f2-43cf-b4db-14903b8215e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f757a680-51b0-4df8-89f9-c19ed6c08d85");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "44546e06-8719-4ad8-b88a-f271ae9d6eab", "09d817ab-3e2d-40c7-a7a8-b2c6d602bcb4", "admin", "ADMIN" },
                    { "44546e05-8719-4ad8-b88a-f271ae9d6eab", "03fb13e3-b95c-4094-8dca-c47fbc9d29d1", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Course", "DateEnd", "Email", "EmailConfirmed", "Faculty", "Firstname", "FormOfEducation", "Group", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Patronymic", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialization", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3b62472e-4f66-49fa-a20f-e7685b9565d8", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "de718ade-578d-4b31-8100-aebc7b8f7247", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "my@email.com", true, null, null, null, null, false, null, "MY@EMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEDJWUn4cHfXqH8PmhMpYqx9zN0CRdQd+6K6F8MBA7Uygqbe25BP5kE84M3l3NKLTKQ==", null, null, false, "", null, null, false, "admin" },
                    { "3b62472e-4f66-49fa-a20f-e7685b9565d9", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fcf1865c-c7cd-4355-bd17-8d766b5f2eaa", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mee@email.com", true, null, null, null, null, false, null, "MEE@EMAIL.COM", "USER", "AQAAAAEAACcQAAAAEPp2FI/J5yMSyh7a7ZwGfdFeAW77R6Ighn4NJ3ZwKM7R7lrp/dMxEhFvCUgnvZxdXw==", null, null, false, "", null, null, false, "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "44546e06-8719-4ad8-b88a-f271ae9d6eab", "3b62472e-4f66-49fa-a20f-e7685b9565d8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "44546e05-8719-4ad8-b88a-f271ae9d6eab", "3b62472e-4f66-49fa-a20f-e7685b9565d9" });
        }
    }
}
