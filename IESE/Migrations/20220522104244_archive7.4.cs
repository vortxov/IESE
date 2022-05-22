using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IESE.Migrations
{
    public partial class archive74 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentCategoryWordDocument");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "WordDocuments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryTitle",
                table: "ArchiveDocuments",
                type: "nvarchar(max)",
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

            migrationBuilder.CreateIndex(
                name: "IX_WordDocuments_CategoryId",
                table: "WordDocuments",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_WordDocuments_DocumentCategories_CategoryId",
                table: "WordDocuments",
                column: "CategoryId",
                principalTable: "DocumentCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WordDocuments_DocumentCategories_CategoryId",
                table: "WordDocuments");

            migrationBuilder.DropIndex(
                name: "IX_WordDocuments_CategoryId",
                table: "WordDocuments");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "WordDocuments");

            migrationBuilder.DropColumn(
                name: "CategoryTitle",
                table: "ArchiveDocuments");

            migrationBuilder.CreateTable(
                name: "DocumentCategoryWordDocument",
                columns: table => new
                {
                    CategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentCategoryWordDocument", x => new { x.CategoriesId, x.DocumentsId });
                    table.ForeignKey(
                        name: "FK_DocumentCategoryWordDocument_DocumentCategories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "DocumentCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentCategoryWordDocument_WordDocuments_DocumentsId",
                        column: x => x.DocumentsId,
                        principalTable: "WordDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_DocumentCategoryWordDocument_DocumentsId",
                table: "DocumentCategoryWordDocument",
                column: "DocumentsId");
        }
    }
}
