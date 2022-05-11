using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IESE.Migrations
{
    public partial class userup6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Course",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "392fb190-6b32-4623-9e6f-adc884524345",
                column: "ConcurrencyStamp",
                value: "252e09c8-274d-4098-b374-acc09e6d0866");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "836d1908-8acb-464e-8d76-426153642557",
                column: "ConcurrencyStamp",
                value: "351f6a5b-811d-45ec-bc7d-07c1bd170d88");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8f8feb0-be4a-4637-8634-4d46d4b06c0d",
                column: "ConcurrencyStamp",
                value: "39a2ded2-d6c8-45d7-ae85-85fcbd5a7715");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f1088f-76ba-4052-8f77-d3572e0ffc90",
                column: "ConcurrencyStamp",
                value: "c6d19414-df10-4f08-b623-72c8a39f1bf0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb91da24-af76-4b5c-ad48-cce1a100bb31",
                column: "ConcurrencyStamp",
                value: "a83a01bb-a8c7-4ae0-8cfd-aaeb2128c20e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05301c29-f5f6-49a9-b967-25025c22922e",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Course", "DateEnd", "PasswordHash" },
                values: new object[] { null, "0c46c55c-403f-41b1-8e59-d2a2db143fc6", null, null, "AQAAAAEAACcQAAAAEHF+L5G6sgbZpdjMJOcjyC9TPLm8lOe7FdAFPaUd5aYjmyDz3VqqguTUj9vf6aEZYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832095e2-5c23-4da1-a83f-b7800e8473a6",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Course", "DateEnd", "PasswordHash" },
                values: new object[] { null, "63a08689-94fa-41fe-8024-c03f2469c914", null, null, "AQAAAAEAACcQAAAAEL8a73/sIhuXeRCdAYi8jEsr0kjfXvrabzeVE5EdKSsObBphqYmCZBa1bbtFzsXXjg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Course", "DateEnd", "PasswordHash" },
                values: new object[] { null, "69565c8a-47e2-42f8-952f-abb85127ff14", null, null, "AQAAAAEAACcQAAAAECd2wX97XsXlUfk3DSe2xE5zaALCiu3FeoS6g2cay0vPe8zuyX5RUSllo7/lPPtaow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Course", "DateEnd", "PasswordHash" },
                values: new object[] { null, "53020d89-fc95-4a7b-a272-6f22320c7aff", null, null, "AQAAAAEAACcQAAAAELRCE9+Fma+04yddrTe30vsS+2BzrnmtoGwTq90H4/YRKi3V4554fVbIQ+Z0MTbX1A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Course", "DateEnd", "PasswordHash" },
                values: new object[] { null, "9a16aea0-314a-4267-9832-113bfe6b203b", null, null, "AQAAAAEAACcQAAAAECxcUlXGcEYNbDdmI4IXx2ej56XP/rfjRzsFZ4sM2zSzHX8Fjq68a5U9udzw5URpNQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEnd",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Course",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "392fb190-6b32-4623-9e6f-adc884524345",
                column: "ConcurrencyStamp",
                value: "976aebee-43e3-4f4f-bcd1-e643eb182369");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "836d1908-8acb-464e-8d76-426153642557",
                column: "ConcurrencyStamp",
                value: "26c8ae73-c76c-42d6-b536-e162576b86fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8f8feb0-be4a-4637-8634-4d46d4b06c0d",
                column: "ConcurrencyStamp",
                value: "b3830642-940a-4891-a251-844bcbc07a65");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f1088f-76ba-4052-8f77-d3572e0ffc90",
                column: "ConcurrencyStamp",
                value: "c5ae9deb-3638-45f1-8b70-98f0e137c6cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb91da24-af76-4b5c-ad48-cce1a100bb31",
                column: "ConcurrencyStamp",
                value: "1c083417-07fc-4b21-97e6-dea7f9e745ab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05301c29-f5f6-49a9-b967-25025c22922e",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Course", "DateEnd", "PasswordHash" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8f87d762-5590-44c7-9df9-b3be7d3e6892", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEJgMEAPiMxFUog5565V29lCvpxaUCJfOFON85xdYzebcWGl0Rw24tdDa3bdeWlXvCw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832095e2-5c23-4da1-a83f-b7800e8473a6",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Course", "DateEnd", "PasswordHash" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "141d03fa-7a4b-43dd-b525-1a59f3776814", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEKuA71e4hA7jcNY29bLGK1koskRpQVIwjLwrWUnvwQ+wttptxjHMDQYbi9dNA5bEXg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Course", "DateEnd", "PasswordHash" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "60bf5915-7179-4b0b-8db2-e0ecc001434d", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEEVyP7MWRuzWH3unCBQ0Fi4LdZO7sIS1K7K6zLEWjOME3P/J+3NPtRcI3co0bH8lEg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Course", "DateEnd", "PasswordHash" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12141c36-6f64-4656-b752-6f2d4c89fff9", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEN4r0kQzoOZLWcNbK2n+7O/rDILq3jB+L6w/elJMOHAezlWmxo43K18JLyqqnwbfuw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "Course", "DateEnd", "PasswordHash" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "63d71054-aa83-426a-a9dd-d42b4683829d", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEKSJfsnnt79Tv/L3uDRxuMiXqGGZ2aWc0/dHsg1LvmlQIAFLYECVzDZp50VgnrDLKw==" });
        }
    }
}
