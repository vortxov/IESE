using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IESE.Migrations
{
    public partial class _4vt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreate",
                table: "WordDocuments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreate",
                table: "WordDocuments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "392fb190-6b32-4623-9e6f-adc884524345",
                column: "ConcurrencyStamp",
                value: "3f95924f-5941-435b-9f20-3041ed4afd20");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "836d1908-8acb-464e-8d76-426153642557",
                column: "ConcurrencyStamp",
                value: "e57bdd23-c306-434a-ab04-56a27a2bc738");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8f8feb0-be4a-4637-8634-4d46d4b06c0d",
                column: "ConcurrencyStamp",
                value: "248ae717-b69e-49c5-b570-1c7f73f733bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f1088f-76ba-4052-8f77-d3572e0ffc90",
                column: "ConcurrencyStamp",
                value: "3d321542-53c6-4100-a7c1-d204020822c0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb91da24-af76-4b5c-ad48-cce1a100bb31",
                column: "ConcurrencyStamp",
                value: "8ab65d4c-f01c-442f-bfd6-282d90853cdf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05301c29-f5f6-49a9-b967-25025c22922e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ef019cd-9996-4cab-825f-91ab94916fd1", "AQAAAAEAACcQAAAAEH2wiSczXKzvviUZoK5+nsbPjqIvquHW0eydIMtYcChUcaTXshVDf+lNd/qTDMueWQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832095e2-5c23-4da1-a83f-b7800e8473a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0bc231f-eba5-4fba-8b33-57d0493cd6f1", "AQAAAAEAACcQAAAAEA8nETcQX/aG8DlvxF+NIFMUevTLMb26rwl4g1vHbcb17P5t8WGhCv1nkaarRf598A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "799546d0-8dd8-494c-b450-2713b6e2c6bc", "AQAAAAEAACcQAAAAELVG0+DOLhHbtU3bvgF0yHR9NbYvi16dsKF83OHF5sSXLpTfukQtalXwCwt1gaWW4A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "08debfd5-585a-45d1-8f68-9da4ad296672", "AQAAAAEAACcQAAAAECTbNnB9cEBenDozZ3NRYtqXqeY72uJYI6NjQ/9gBtX6Nh+vDf1lYmEdFQRcRyYQ+g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6b59720f-602c-4146-b55d-dc7d3e701c79", "AQAAAAEAACcQAAAAEPpgThVjPGGelOly7z2HnQD+cf8B3BEsSpHFer50adb+FGbte+Rd2MF4qMpZeWgshw==" });
        }
    }
}
