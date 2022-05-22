using Microsoft.EntityFrameworkCore.Migrations;

namespace IESE.Migrations
{
    public partial class archive72 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ArchiveDocuments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "392fb190-6b32-4623-9e6f-adc884524345",
                column: "ConcurrencyStamp",
                value: "ff95f1c5-2b12-402c-8b1a-1ba1ce7676ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "836d1908-8acb-464e-8d76-426153642557",
                column: "ConcurrencyStamp",
                value: "754a6c60-b0ed-4313-a60f-a6286af1e72f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8f8feb0-be4a-4637-8634-4d46d4b06c0d",
                column: "ConcurrencyStamp",
                value: "4e4c5acf-2ee8-4c8e-81a7-3293bd1276c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f1088f-76ba-4052-8f77-d3572e0ffc90",
                column: "ConcurrencyStamp",
                value: "50b912c8-f605-4bc5-bd26-e277d7e96f53");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb91da24-af76-4b5c-ad48-cce1a100bb31",
                column: "ConcurrencyStamp",
                value: "14f363b6-5f72-4e6c-ba91-3d53a3789de2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05301c29-f5f6-49a9-b967-25025c22922e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6fd43b32-1faf-458c-a0e7-02b932f90e53", "AQAAAAEAACcQAAAAEI0sj8+2qapkmyowftFQsAs/eWDNgYf0cOnFvKGL6JCgJ/Pk0nZrWybZZeY2TMpITQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832095e2-5c23-4da1-a83f-b7800e8473a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a6724d6-571d-479f-a761-190f7ec137f0", "AQAAAAEAACcQAAAAEGRhSSdI6bvC/rpRFNUP8GzAEc9P9s5A3JsJWyPGxFuRTvsTHn7sI1MNBdkO195GnA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9532b07b-9cf8-44b4-877b-37a37aab499f", "AQAAAAEAACcQAAAAEJOE8/do6ZqFJ9qy1oTuYVUPiZhK+Q2n1BfYJB7MmqzfxQ3avTolck+oIP0lfIyXjw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8860247b-bb24-4b89-8730-758fdd22b4a0", "AQAAAAEAACcQAAAAEK/9tXEE7VwMr+V+dLfRpg8umF7oU8hby/HxJacVoNfN3LK9RiDau3PCoDjDlP/M/w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b0ab38e-a2ac-4420-8482-58f851cadfd9", "AQAAAAEAACcQAAAAEH+cK5GrMFJxLQq+WoQj23Sgv6AqQWVxHNppnq4U5wGWI40Wi7ablYQy36nowVovug==" });

            migrationBuilder.CreateIndex(
                name: "IX_ArchiveDocuments_UserId",
                table: "ArchiveDocuments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArchiveDocuments_AspNetUsers_UserId",
                table: "ArchiveDocuments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArchiveDocuments_AspNetUsers_UserId",
                table: "ArchiveDocuments");

            migrationBuilder.DropIndex(
                name: "IX_ArchiveDocuments_UserId",
                table: "ArchiveDocuments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ArchiveDocuments");

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
    }
}
