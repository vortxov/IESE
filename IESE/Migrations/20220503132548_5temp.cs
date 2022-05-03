using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IESE.Migrations
{
    public partial class _5temp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WordDocumentWordTemplate");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "392fb190-6b32-4623-9e6f-adc884524345",
                column: "ConcurrencyStamp",
                value: "4ec56727-3f5a-42ea-af6a-783de181a3ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "836d1908-8acb-464e-8d76-426153642557",
                column: "ConcurrencyStamp",
                value: "b333d21d-69f8-4eaa-8c55-cbbf57cb0813");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8f8feb0-be4a-4637-8634-4d46d4b06c0d",
                column: "ConcurrencyStamp",
                value: "66ff43e5-9cef-4d35-a4c2-8fec3db9edeb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f1088f-76ba-4052-8f77-d3572e0ffc90",
                column: "ConcurrencyStamp",
                value: "d1215d2e-0ab0-45ad-93ac-164091088274");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb91da24-af76-4b5c-ad48-cce1a100bb31",
                column: "ConcurrencyStamp",
                value: "50d5428f-7628-4c76-ab56-690cc9344d2b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05301c29-f5f6-49a9-b967-25025c22922e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "14022737-0010-4ba9-99fe-d18bec31a014", "AQAAAAEAACcQAAAAEOW5zYHaTEPLVELT58QQGIaKy2pO/xaLrEzwTPtZ0SHUmkd2iCK7pnUU9YHxuSiGKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832095e2-5c23-4da1-a83f-b7800e8473a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2657bdcd-35ae-4175-969b-0b44c22b3cf3", "AQAAAAEAACcQAAAAEO+vUEtnLhSwQyLLpojyJ859zn+Y9R/lsB5EH/mZMwe3hCKa2DOrEeUdZMIiMUdoEQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b3a60879-4719-4359-9590-9b2fcc5426d5", "AQAAAAEAACcQAAAAEL8eEFRTJ3T7D/OhhcCrEinnGNWPrvwLN5p2267U9B9AFG/j3V7+saWWWL2NAAnFpg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "510f7b78-28e4-4991-9104-688e6c612855", "AQAAAAEAACcQAAAAEJe7BVnP8om7ySvPiVDqRDRc4ik1/+oBMe4FLzmVAdjQyvAxT4KwlV7FibnuZmh4Zw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02293d6b-1660-49f6-a7f4-ac8c6b649de2", "AQAAAAEAACcQAAAAEO26p/6ftsDitPEvUk3OsGCPoZ4oiJluHA+echLw4mrY5Hc0u9yosFY6WvJMsm4+0g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WordDocumentWordTemplate",
                columns: table => new
                {
                    DocumentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TemplatesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordDocumentWordTemplate", x => new { x.DocumentsId, x.TemplatesId });
                    table.ForeignKey(
                        name: "FK_WordDocumentWordTemplate_WordDocuments_DocumentsId",
                        column: x => x.DocumentsId,
                        principalTable: "WordDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WordDocumentWordTemplate_WordTemplates_TemplatesId",
                        column: x => x.TemplatesId,
                        principalTable: "WordTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "392fb190-6b32-4623-9e6f-adc884524345",
                column: "ConcurrencyStamp",
                value: "2845159f-1020-4f46-931f-d2e15b9249ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "836d1908-8acb-464e-8d76-426153642557",
                column: "ConcurrencyStamp",
                value: "d18bb526-57ba-4d05-a433-6a1ff90aaf4e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8f8feb0-be4a-4637-8634-4d46d4b06c0d",
                column: "ConcurrencyStamp",
                value: "fc52cef7-4447-4163-b517-0610cfdf3d42");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f1088f-76ba-4052-8f77-d3572e0ffc90",
                column: "ConcurrencyStamp",
                value: "ff053ffd-383f-4388-b313-01ba1b3148f3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb91da24-af76-4b5c-ad48-cce1a100bb31",
                column: "ConcurrencyStamp",
                value: "93d15ab1-2356-4aca-9a91-5cc28f897576");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05301c29-f5f6-49a9-b967-25025c22922e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d397574b-ff3f-4e94-a6e4-bda720aa2ec1", "AQAAAAEAACcQAAAAELn2JGraMKmTkHHgZyA+jNt2RA6Mk9h1YXZNMeF9Q5ev/klvIyP9qVRvC/Cy0mJwaw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832095e2-5c23-4da1-a83f-b7800e8473a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4d253d54-7fb4-4530-b896-23943df76548", "AQAAAAEAACcQAAAAEEcML8rtAStTIb+Sh5X/ka+obKerakfvegLHsF4n/HMuxCgvJ3VQBzpqsrNIRmSw9A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b201dc33-2ba5-4bce-aea2-1197df4ce019", "AQAAAAEAACcQAAAAEH/R4veMHcXw222lukEGg6Z94vAzrr8Bc2Yp8jzOXP9vjk4y6spc8GBmnbjRc07I+A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74020bf2-df94-4664-a030-fd62332653fb", "AQAAAAEAACcQAAAAEBZqLygTv3aZM4/0v5b6z6mZE3Cv/Cy7xXNQ9QxmFooM5xdG1uC66fPxEarP7xpbTA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d601667-89d0-4263-92c2-89609865e95c", "AQAAAAEAACcQAAAAENVioth1cPgRpHuGXihHLV0ogBe+DNUunAcQthUK4O4TJYWV6eQuULxwpDFoERRHPQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_WordDocumentWordTemplate_TemplatesId",
                table: "WordDocumentWordTemplate",
                column: "TemplatesId");
        }
    }
}
