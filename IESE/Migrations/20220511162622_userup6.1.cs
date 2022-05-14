using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IESE.Migrations
{
    public partial class userup61 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEnd",
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

            migrationBuilder.AddColumn<string>(
                name: "FinancialSupport",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QualificationLevel",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "AspNetRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "392fb190-6b32-4623-9e6f-adc884524345",
                column: "ConcurrencyStamp",
                value: "56ea3dd1-1d83-4098-9859-c9f27aeac67b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "836d1908-8acb-464e-8d76-426153642557",
                column: "ConcurrencyStamp",
                value: "bdcf4d71-6119-4b1c-9e65-8479d4fb48dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8f8feb0-be4a-4637-8634-4d46d4b06c0d",
                column: "ConcurrencyStamp",
                value: "82fb2c87-878e-4e99-b295-8f1ed587ab28");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f1088f-76ba-4052-8f77-d3572e0ffc90",
                column: "ConcurrencyStamp",
                value: "4be06adc-40a1-4d57-af74-16426371b160");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb91da24-af76-4b5c-ad48-cce1a100bb31",
                column: "ConcurrencyStamp",
                value: "334e357e-4073-45bd-bd7c-640fed5ec7b4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05301c29-f5f6-49a9-b967-25025c22922e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6c9a0728-d7f9-49c2-85ba-adcb9abaff45", "AQAAAAEAACcQAAAAEMDb6ArKy0t9aonNL91dOVzIVspuZoDlW/tziwWlYBtTgR/9enH2ylTAv4hRClVbEg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832095e2-5c23-4da1-a83f-b7800e8473a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6e5552b3-2db0-4e94-988c-86880bac8bfc", "AQAAAAEAACcQAAAAEFixUGJoAnLiA15L++KTaY3YFwAHYML++JtYt7O4dOegoY1RAaWly4n4JXG63f6mRg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5af9564f-1678-436a-bd30-473ffee66c44", "AQAAAAEAACcQAAAAENQSYJl0YfrSjoDzwQfUad55Dzn+TDCZKryDPy0xyYufLgGa9YyfLQg8os6I+UXssA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf4fddc3-928f-4dd8-8b64-04ff67d29050", "AQAAAAEAACcQAAAAEBCZ9rvjwEK4Njs8qUWtubeYVBXbIRzlwheiRmeSEKKR6IxdhkHwpeTtJ4F1szipWQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fd89ac04-80d0-44f1-b304-86c59d6c1e99", "AQAAAAEAACcQAAAAEEcX0/rps3me5XU2LFUaa4DEtACzZvMbxCGHyRCwZ5VSAzhf5d4evV508auWLMOH4A==" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_ApplicationUserId",
                table: "AspNetRoles",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_ApplicationUserId",
                table: "AspNetRoles",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_ApplicationUserId",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_ApplicationUserId",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "DateEndYear",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateStartYear",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FinancialSupport",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "QualificationLevel",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AspNetRoles");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateEnd",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0c46c55c-403f-41b1-8e59-d2a2db143fc6", "AQAAAAEAACcQAAAAEHF+L5G6sgbZpdjMJOcjyC9TPLm8lOe7FdAFPaUd5aYjmyDz3VqqguTUj9vf6aEZYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832095e2-5c23-4da1-a83f-b7800e8473a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "63a08689-94fa-41fe-8024-c03f2469c914", "AQAAAAEAACcQAAAAEL8a73/sIhuXeRCdAYi8jEsr0kjfXvrabzeVE5EdKSsObBphqYmCZBa1bbtFzsXXjg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69565c8a-47e2-42f8-952f-abb85127ff14", "AQAAAAEAACcQAAAAECd2wX97XsXlUfk3DSe2xE5zaALCiu3FeoS6g2cay0vPe8zuyX5RUSllo7/lPPtaow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53020d89-fc95-4a7b-a272-6f22320c7aff", "AQAAAAEAACcQAAAAELRCE9+Fma+04yddrTe30vsS+2BzrnmtoGwTq90H4/YRKi3V4554fVbIQ+Z0MTbX1A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a16aea0-314a-4267-9832-113bfe6b203b", "AQAAAAEAACcQAAAAECxcUlXGcEYNbDdmI4IXx2ej56XP/rfjRzsFZ4sM2zSzHX8Fjq68a5U9udzw5URpNQ==" });
        }
    }
}
