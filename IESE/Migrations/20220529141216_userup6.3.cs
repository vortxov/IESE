using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IESE.Migrations
{
    public partial class userup63 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NumberDocuments",
                keyColumn: "Id",
                keyValue: new Guid("db4817e3-511c-463e-93cc-cba7af381d4f"));

            migrationBuilder.AddColumn<int>(
                name: "NumberOrder",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "392fb190-6b32-4623-9e6f-adc884524345",
                column: "ConcurrencyStamp",
                value: "7560ec6b-c408-4b52-95ba-3acfca7b7d8a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "836d1908-8acb-464e-8d76-426153642557",
                column: "ConcurrencyStamp",
                value: "cfd8d5ef-00c3-457a-812d-20b45ef1553c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8f8feb0-be4a-4637-8634-4d46d4b06c0d",
                column: "ConcurrencyStamp",
                value: "3535270d-8c53-4730-9ad9-caab67281739");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f1088f-76ba-4052-8f77-d3572e0ffc90",
                column: "ConcurrencyStamp",
                value: "9f518fd0-9b00-4765-acca-6f9026520703");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb91da24-af76-4b5c-ad48-cce1a100bb31",
                column: "ConcurrencyStamp",
                value: "76cbd6ae-e7be-4a1c-8f52-9f3c62f26480");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05301c29-f5f6-49a9-b967-25025c22922e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0c502dc2-c38d-4f11-8709-7d34153aa462", "AQAAAAEAACcQAAAAEIfuj3StT5sqNossbYgV65JWF0jBD8Xbsqrcf4xtfOlZ/pOHlIDiJRNMmZhZJzNnFA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832095e2-5c23-4da1-a83f-b7800e8473a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d335e0b9-abc0-4612-b9f3-6a07391ee4dc", "AQAAAAEAACcQAAAAED0o2J0uJi1GN4qB3em6zR6ZFC9voPOMw7s5Lb1Gz1p9NQVpyYwa03wYjnEf3AbzQw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf8b6bf7-1028-417e-8b0b-d4649f7f9a6d", "AQAAAAEAACcQAAAAECIRXeprut5K8a+sJ0enl6GT0OFBU42r9HM7lyroQRS4NVMDP5dntKYOsI3Ul5FRfw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "633058e9-b300-4ceb-ad01-570045e6272b", "AQAAAAEAACcQAAAAEFeXFqrNuw8EZu4O8c8OWoDoe4yiQt7ZyefJwCdW9mRED3IR9u6jsQ+gwpgsaGCt5Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "720db4c3-6a4d-4510-8abd-f3f48cb517c3", "AQAAAAEAACcQAAAAEDRs6goDRk3I5ozYYNtDBfzCyaqzauBBNxwgaHhoWND2tkkLRG3ZdtygOv+w1mnIYw==" });

            migrationBuilder.InsertData(
                table: "NumberDocuments",
                columns: new[] { "Id", "Number" },
                values: new object[] { new Guid("60ae8bd6-30ff-444e-8e02-692e6a21b056"), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NumberDocuments",
                keyColumn: "Id",
                keyValue: new Guid("60ae8bd6-30ff-444e-8e02-692e6a21b056"));

            migrationBuilder.DropColumn(
                name: "NumberOrder",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "392fb190-6b32-4623-9e6f-adc884524345",
                column: "ConcurrencyStamp",
                value: "2455d3c6-e145-43c2-8203-23a4f0f47c9a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "836d1908-8acb-464e-8d76-426153642557",
                column: "ConcurrencyStamp",
                value: "dbf05a83-777d-41bc-bb97-6878c8efabd7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8f8feb0-be4a-4637-8634-4d46d4b06c0d",
                column: "ConcurrencyStamp",
                value: "17599308-104f-4eb0-82c9-a9b0f1d96e17");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f1088f-76ba-4052-8f77-d3572e0ffc90",
                column: "ConcurrencyStamp",
                value: "df850328-6072-4d94-a416-613c3e9bcab2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb91da24-af76-4b5c-ad48-cce1a100bb31",
                column: "ConcurrencyStamp",
                value: "a0f4fe6d-0981-405a-af6e-19e4062574f6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05301c29-f5f6-49a9-b967-25025c22922e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c347fb14-85d1-4b7b-8b71-64f4d468b0af", "AQAAAAEAACcQAAAAELb2y2bFjNfqhfocN6O0iXL4TWl3XLq3QvCaB8Y0AQCRmfpnSAjqJE+MC9eRHsoxig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832095e2-5c23-4da1-a83f-b7800e8473a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b44c3f1-b3a5-4738-9be2-512ff0913141", "AQAAAAEAACcQAAAAEIMCDE2cWVv7Zf+Bz7J1vc/xBFS2GnBKCHiqVUtHNfKWkbM6ItiM5gEud7e3gpCqCg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83e5cde4-3926-4d97-a42c-ecbcfd5f051b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe03353d-d540-4806-b4e8-617d450b1676", "AQAAAAEAACcQAAAAEKeHK890cEpv3az4whflUYp6GhmF31jTDrlXIW6jdDi2EgZ4khCgVDDOOHDYAA05gg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f07b07c6-f9f2-43cf-b4db-14903b8215e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9fd1f44b-18c6-4203-9296-63495d58aad1", "AQAAAAEAACcQAAAAENLsxZP3jyFo2xaEvGAIsWC7tbyp5IdSwfR4VAqik7z0HZsK7SzNbu5w3dZt87uRrw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f757a680-51b0-4df8-89f9-c19ed6c08d85",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e7ecd21e-bb1e-4b80-82f9-b18b912163b0", "AQAAAAEAACcQAAAAEC9gjEla9bSyu5aEcb0JRuqkLM151KAfQGRMMO0e8K1y8RgUddkvujQg1/MxRPyvWQ==" });

            migrationBuilder.InsertData(
                table: "NumberDocuments",
                columns: new[] { "Id", "Number" },
                values: new object[] { new Guid("db4817e3-511c-463e-93cc-cba7af381d4f"), 1 });
        }
    }
}
