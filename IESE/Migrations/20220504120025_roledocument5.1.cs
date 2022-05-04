using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IESE.Migrations
{
    public partial class roledocument51 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "WordDocumentId",
                table: "AspNetRoles",
                type: "uniqueidentifier",
                nullable: true);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8f87d762-5590-44c7-9df9-b3be7d3e6892", "AQAAAAEAACcQAAAAEJgMEAPiMxFUog5565V29lCvpxaUCJfOFON85xdYzebcWGl0Rw24tdDa3bdeWlXvCw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832095e2-5c23-4da1-a83f-b7800e8473a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "141d03fa-7a4b-43dd-b525-1a59f3776814", "AQAAAAEAACcQAAAAEKuA71e4hA7jcNY29bLGK1koskRpQVIwjLwrWUnvwQ+wttptxjHMDQYbi9dNA5bEXg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "60bf5915-7179-4b0b-8db2-e0ecc001434d", "AQAAAAEAACcQAAAAEEVyP7MWRuzWH3unCBQ0Fi4LdZO7sIS1K7K6zLEWjOME3P/J+3NPtRcI3co0bH8lEg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "12141c36-6f64-4656-b752-6f2d4c89fff9", "AQAAAAEAACcQAAAAEN4r0kQzoOZLWcNbK2n+7O/rDILq3jB+L6w/elJMOHAezlWmxo43K18JLyqqnwbfuw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "63d71054-aa83-426a-a9dd-d42b4683829d", "AQAAAAEAACcQAAAAEKSJfsnnt79Tv/L3uDRxuMiXqGGZ2aWc0/dHsg1LvmlQIAFLYECVzDZp50VgnrDLKw==" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_WordDocumentId",
                table: "AspNetRoles",
                column: "WordDocumentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_WordDocuments_WordDocumentId",
                table: "AspNetRoles",
                column: "WordDocumentId",
                principalTable: "WordDocuments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_WordDocuments_WordDocumentId",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_WordDocumentId",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "WordDocumentId",
                table: "AspNetRoles");

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
    }
}
