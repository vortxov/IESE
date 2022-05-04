using Microsoft.EntityFrameworkCore.Migrations;

namespace IESE.Migrations
{
    public partial class roledocument5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RoleId",
                table: "WordDocuments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "392fb190-6b32-4623-9e6f-adc884524345",
                column: "ConcurrencyStamp",
                value: "56ca4201-8936-4765-a065-dd51e7a43d21");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "836d1908-8acb-464e-8d76-426153642557",
                column: "ConcurrencyStamp",
                value: "b9c2061b-bb10-44cd-83b4-d83ab620843c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8f8feb0-be4a-4637-8634-4d46d4b06c0d",
                column: "ConcurrencyStamp",
                value: "4c6e3a9e-f4e0-47c8-8b0c-4580a0fd3e86");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f1088f-76ba-4052-8f77-d3572e0ffc90",
                column: "ConcurrencyStamp",
                value: "7de1795c-b6ad-4772-86c9-2fc2cb440461");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb91da24-af76-4b5c-ad48-cce1a100bb31",
                column: "ConcurrencyStamp",
                value: "92f38d66-fe35-4286-a565-f65b50c710ae");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05301c29-f5f6-49a9-b967-25025c22922e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19a69f0d-73ee-4901-b3bf-c6ad39caa2d7", "AQAAAAEAACcQAAAAEMZdtYZLGxJjQa3gu3PXVgeOOSCDwRDoBVGM49II9JX0pT7PY5VbpPLFnmtujfOQow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832095e2-5c23-4da1-a83f-b7800e8473a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8742d8ac-f9c4-4c3f-b662-d98218154954", "AQAAAAEAACcQAAAAENPuZku+iHOkxYUlOVVqMqX54pr2IeLGLOxX7yuyxm5zu4t9jMRF8e0krR43UfDxsA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "48ed2f02-49f2-43b5-a55a-054e544aee80", "AQAAAAEAACcQAAAAEECuFgAl2je6iuVSS2+CoJPTWXJ0zFFT7HzY0H1pT0SL0ZCV8qV2t3fq+oEiMBULIg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "42dffabd-1bc3-4a3d-829d-1b90170e742e", "AQAAAAEAACcQAAAAEIZ+06GGni4yvSzCJS9mKKWxt8LuZwOYxGYkLKzWNfRvK4kkVFcJjvlhma/poKM7YQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b79d787f-ea60-4b2a-888e-0c0fc2fe800d", "AQAAAAEAACcQAAAAEGHjwBRHnpHfZ9vE4S6sIZvv+i3FqVqp7Hb2vCiAYjCMz22GB2w6adxmcqT+hLih4g==" });

            migrationBuilder.CreateIndex(
                name: "IX_WordDocuments_RoleId",
                table: "WordDocuments",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_WordDocuments_AspNetRoles_RoleId",
                table: "WordDocuments",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WordDocuments_AspNetRoles_RoleId",
                table: "WordDocuments");

            migrationBuilder.DropIndex(
                name: "IX_WordDocuments_RoleId",
                table: "WordDocuments");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "WordDocuments");

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
    }
}
