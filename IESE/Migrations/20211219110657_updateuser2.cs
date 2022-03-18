using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IESE.Migrations
{
    public partial class updateuser2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateEnd",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Specialization",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e05-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "03fb13e3-b95c-4094-8dca-c47fbc9d29d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "09d817ab-3e2d-40c7-a7a8-b2c6d602bcb4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de718ade-578d-4b31-8100-aebc7b8f7247", "AQAAAAEAACcQAAAAEDJWUn4cHfXqH8PmhMpYqx9zN0CRdQd+6K6F8MBA7Uygqbe25BP5kE84M3l3NKLTKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fcf1865c-c7cd-4355-bd17-8d766b5f2eaa", "AQAAAAEAACcQAAAAEPp2FI/J5yMSyh7a7ZwGfdFeAW77R6Ighn4NJ3ZwKM7R7lrp/dMxEhFvCUgnvZxdXw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateEnd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Specialization",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e05-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "c4c851a3-6ec1-42f2-a887-e179d9c5b8ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "b57d50f8-ffc5-4d07-934c-b613d837bc2e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d71e0c4c-be1f-4dcb-bdf0-e6251fb2cef2", "AQAAAAEAACcQAAAAEH95iJ6VftCFzuT28/4dGkLD64wJXFYljiI7AhmSJALdFhe64cmyi+lKsbL6w0pHlg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cb3a989e-70a7-4a9c-8413-5615f99c27c0", "AQAAAAEAACcQAAAAEPSu/bQABtcldcAJCwCtcmdyX5ql0UJtJd2dOKxr6tQVHP31B+4PytPcIVolwvQ/Lw==" });
        }
    }
}
