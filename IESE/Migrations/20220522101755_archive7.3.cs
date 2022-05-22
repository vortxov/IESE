using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IESE.Migrations
{
    public partial class archive73 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateCreate",
                table: "ArchiveDocuments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "392fb190-6b32-4623-9e6f-adc884524345",
                column: "ConcurrencyStamp",
                value: "d70092e2-83c7-4b2d-84c7-de617594ed71");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "836d1908-8acb-464e-8d76-426153642557",
                column: "ConcurrencyStamp",
                value: "2df28bd8-90d9-4a66-82b6-55634f7a8e81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8f8feb0-be4a-4637-8634-4d46d4b06c0d",
                column: "ConcurrencyStamp",
                value: "28ad0de3-c99d-445b-846b-a0943a17d2fc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f1088f-76ba-4052-8f77-d3572e0ffc90",
                column: "ConcurrencyStamp",
                value: "3c900a4c-b94c-44a6-bf5f-1ac1c88e7aa6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb91da24-af76-4b5c-ad48-cce1a100bb31",
                column: "ConcurrencyStamp",
                value: "6961fa05-8514-494f-bd86-16112e32a7a7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05301c29-f5f6-49a9-b967-25025c22922e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "710c5540-dd8c-4388-a41f-a9e3051a48fd", "AQAAAAEAACcQAAAAEDubZ9KVzUzGGJnuQS1khzk3AEVGGR5MLRNCC3+V8husGCQiqevdDFVlZp+6kBX6aA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832095e2-5c23-4da1-a83f-b7800e8473a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "90958cd2-5a85-4e9e-8030-4d60db7cb9ae", "AQAAAAEAACcQAAAAEEZkWrxKTFENZLrotqnWah/gCBPDxLIbPNEsXrQn0JnqjQDzS9Ndb7xW6g5ZH28/NA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc6e8ca4-177b-4581-8ba4-a6d7d54b75b9", "AQAAAAEAACcQAAAAENYlQUOr58+SqwMQzRzd3F0KTVO87yMXi0iLnl8hqVruver3CYJUmLegpFVbHKP9kw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8f671970-a941-4411-9cea-df45620ab21b", "AQAAAAEAACcQAAAAEN3ja1l2P5006EFc3cBlxWUlnNtSjt9D0grhKtxfBZ5m9Iwlbz4p5fWRNO2Sigxw3w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6f072faa-909c-4cf8-924c-3d3269d84357", "AQAAAAEAACcQAAAAEKmX26pDBFoKXGSKq5x715alBEJFjN7qjMue3pCErlRN7nqM43u8n/Md7MwFdgGjwg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "ArchiveDocuments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
