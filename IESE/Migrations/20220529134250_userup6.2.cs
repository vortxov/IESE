using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IESE.Migrations
{
    public partial class userup62 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEndYear",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateStartYear",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCredited",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateEnd",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOrder",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateStart",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateStartStudy",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "NumberDocuments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumberDocuments", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "392fb190-6b32-4623-9e6f-adc884524345",
                column: "ConcurrencyStamp",
                value: "2455d3c6-e145-43c2-8203-23a4f0f47c9a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "836d1908-8acb-464e-8d76-426153642557",
                column: "ConcurrencyStamp",
                value: "dbf05a83-777d-41bc-bb97-6878c8efabd7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8f8feb0-be4a-4637-8634-4d46d4b06c0d",
                column: "ConcurrencyStamp",
                value: "17599308-104f-4eb0-82c9-a9b0f1d96e17");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f1088f-76ba-4052-8f77-d3572e0ffc90",
                column: "ConcurrencyStamp",
                value: "df850328-6072-4d94-a416-613c3e9bcab2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb91da24-af76-4b5c-ad48-cce1a100bb31",
                column: "ConcurrencyStamp",
                value: "a0f4fe6d-0981-405a-af6e-19e4062574f6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05301c29-f5f6-49a9-b967-25025c22922e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c347fb14-85d1-4b7b-8b71-64f4d468b0af", "AQAAAAEAACcQAAAAELb2y2bFjNfqhfocN6O0iXL4TWl3XLq3QvCaB8Y0AQCRmfpnSAjqJE+MC9eRHsoxig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832095e2-5c23-4da1-a83f-b7800e8473a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b44c3f1-b3a5-4738-9be2-512ff0913141", "AQAAAAEAACcQAAAAEIMCDE2cWVv7Zf+Bz7J1vc/xBFS2GnBKCHiqVUtHNfKWkbM6ItiM5gEud7e3gpCqCg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe03353d-d540-4806-b4e8-617d450b1676", "AQAAAAEAACcQAAAAEKeHK890cEpv3az4whflUYp6GhmF31jTDrlXIW6jdDi2EgZ4khCgVDDOOHDYAA05gg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9fd1f44b-18c6-4203-9296-63495d58aad1", "AQAAAAEAACcQAAAAENLsxZP3jyFo2xaEvGAIsWC7tbyp5IdSwfR4VAqik7z0HZsK7SzNbu5w3dZt87uRrw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e7ecd21e-bb1e-4b80-82f9-b18b912163b0", "AQAAAAEAACcQAAAAEC9gjEla9bSyu5aEcb0JRuqkLM151KAfQGRMMO0e8K1y8RgUddkvujQg1/MxRPyvWQ==" });

            migrationBuilder.InsertData(
                table: "NumberDocuments",
                columns: new[] { "Id", "Number" },
                values: new object[] { new Guid("db4817e3-511c-463e-93cc-cba7af381d4f"), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NumberDocuments");

            migrationBuilder.DropColumn(
                name: "DateCredited",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateEnd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateOrder",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateStart",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateStartStudy",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "DateEndYear",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DateStartYear",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "392fb190-6b32-4623-9e6f-adc884524345",
                column: "ConcurrencyStamp",
                value: "0c2d1ae0-cec2-4fcc-8d33-6a55e2eafa23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "836d1908-8acb-464e-8d76-426153642557",
                column: "ConcurrencyStamp",
                value: "161610fb-5d95-4ac0-a280-a864eb7327a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8f8feb0-be4a-4637-8634-4d46d4b06c0d",
                column: "ConcurrencyStamp",
                value: "700e53a6-5302-4a65-be37-44fcb130eebd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f1088f-76ba-4052-8f77-d3572e0ffc90",
                column: "ConcurrencyStamp",
                value: "64ec104d-d90c-4f44-8e07-f7d273949450");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb91da24-af76-4b5c-ad48-cce1a100bb31",
                column: "ConcurrencyStamp",
                value: "0b03e56b-fcd7-4990-a69d-72bdc72b9747");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05301c29-f5f6-49a9-b967-25025c22922e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a2d2ae3-6088-4286-922d-646d1e0c80cd", "AQAAAAEAACcQAAAAEDkI4BdGaJuDlQ9r2zt7kWbmfLY/SqyJz9+g1qC38s3eAl3s9UC4LYfnSzo8oaKyzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832095e2-5c23-4da1-a83f-b7800e8473a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ce347df-2397-4891-9f36-e30e24ff50a9", "AQAAAAEAACcQAAAAENrWlOl2IPZ3MKElEbVSs7wKFS1FdoE6IucZx+i0jR9gzhQI74uTpBBMi2rQ/IaT0w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "821f76b3-0bd9-4d29-a3f9-68b170289901", "AQAAAAEAACcQAAAAENho7xoZLxV8eKy3nm67IJzNlyjkize6yNrfPgJZINgBNvRKQiFfo1oko6auhLwduw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e09e5a56-3996-48c5-b7de-e71fc2c9ad2e", "AQAAAAEAACcQAAAAEN0Uk4isTkCpOLa1t1kpCEs2ybzKcDGSLxhEfgQa8Ql+3UF1j5FpMfCnexgbGyaXbQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d379899f-1cfb-4bbf-b461-d29861b6dcae", "AQAAAAEAACcQAAAAEK6FWXd3OS1YMTkfFsi2qHiQ0rFn2C1nWl5SBPFzvJmFS0NsMneIehwynJEET7wtBQ==" });
        }
    }
}
