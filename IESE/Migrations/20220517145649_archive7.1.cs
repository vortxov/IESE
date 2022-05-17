using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IESE.Migrations
{
    public partial class archive71 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArchiveDocuments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDocument = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PathWord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PathPDF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchiveDocuments", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "392fb190-6b32-4623-9e6f-adc884524345",
                column: "ConcurrencyStamp",
                value: "69e2cf7b-f34b-4b58-8fb6-78dc380a3852");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "836d1908-8acb-464e-8d76-426153642557",
                column: "ConcurrencyStamp",
                value: "7aa98f4b-291e-4762-a3fe-d61e304aa934");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8f8feb0-be4a-4637-8634-4d46d4b06c0d",
                column: "ConcurrencyStamp",
                value: "646b11cd-88d0-4366-9890-38f6b6c513a3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f1088f-76ba-4052-8f77-d3572e0ffc90",
                column: "ConcurrencyStamp",
                value: "00a2c802-6d8f-4485-b73f-ae797a027fdc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb91da24-af76-4b5c-ad48-cce1a100bb31",
                column: "ConcurrencyStamp",
                value: "52a10556-f964-4272-8412-cc10aa46f7c4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05301c29-f5f6-49a9-b967-25025c22922e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c062c87d-0f97-445b-b8c7-9b21ca639dea", "AQAAAAEAACcQAAAAEGBXa+MuW0iCV12evDLC764/hr9A/e0SXEJAASI/2RVnvfKm6rDo116ZzjiosS8TsA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832095e2-5c23-4da1-a83f-b7800e8473a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "885410c8-3bd9-4e62-a56c-72b869256afc", "AQAAAAEAACcQAAAAEJ8Su70ivbXk5QGIPv3r5pbJJMCl3EjTWWV+yvzLYJAdmHzdxkcdfzuMO6XMQvNeuQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f13bf822-d44c-44f4-b13f-9394622a1a95", "AQAAAAEAACcQAAAAEHLinKf2qvC0c70ys7qJ8+nFYOr11p+bgEIa2EUeWclzB8J9hNNjARxRcC68U9shTw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "05b0a7cd-a618-45d6-9879-0d020c07df4c", "AQAAAAEAACcQAAAAEPM84WSq8SBnhKUGTg17DdLDxBrxqHL1Hw2Y/g/NqUVjfVZii+k/UlAIHHEVr4IHxw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "046ca558-6ef7-4e0b-b2cc-6795798280c3", "AQAAAAEAACcQAAAAEPe4khG0c4QWpptc342ecNLu3JZme20+gcURTChpCJJ9u7xP6CxW2fQFmsTeCtdwbw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArchiveDocuments");

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
        }
    }
}
