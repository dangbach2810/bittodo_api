using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProjectManager.Models.Migrations
{
    public partial class adddescol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("e87ac7c5-95a5-46dd-92e4-9785bf11b5f3") });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e87ac7c5-95a5-46dd-92e4-9785bf11b5f3"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("d21c6259-633e-45aa-b113-9051ed23edd7") });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c8fc841f-417a-4adb-9973-8f74794d9e91");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedOn", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Gender", "IsActive", "IsVerification", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedOn", "UrlAvatar", "UserName" },
                values: new object[] { new Guid("d21c6259-633e-45aa-b113-9051ed23edd7"), 0, "Đà Nẵng", "d2239047-f20d-43a3-a9c8-ac371a61c572", new DateTime(2024, 5, 2, 10, 10, 8, 337, DateTimeKind.Local).AddTicks(5692), new DateTime(2000, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Nam", true, true, true, "Tran Thanh", false, null, "ADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEHsanHzvgjFg1Bx8jj2Yh85UP4KlJzbiaYEHdFgNQFvfhjs+lqYnkVbFdFZNb7iSEQ==", "0968354148", false, "", false, new DateTime(2024, 5, 2, 10, 10, 8, 337, DateTimeKind.Local).AddTicks(5704), "/upload/avatar/admin1.jpg", "admin123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("d21c6259-633e-45aa-b113-9051ed23edd7") });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d21c6259-633e-45aa-b113-9051ed23edd7"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Cards");

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("e87ac7c5-95a5-46dd-92e4-9785bf11b5f3") });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "ba0c0e46-5d0a-4d6f-a5fb-16360f204b7b");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedOn", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Gender", "IsActive", "IsVerification", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedOn", "UrlAvatar", "UserName" },
                values: new object[] { new Guid("e87ac7c5-95a5-46dd-92e4-9785bf11b5f3"), 0, "Đà Nẵng", "ad25a31b-2fb4-4f72-a313-246d8f5d2fb8", new DateTime(2022, 4, 9, 11, 20, 3, 905, DateTimeKind.Local).AddTicks(6499), new DateTime(2000, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Nam", true, true, true, "Tran Thanh", false, null, "ADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEBn/lfgI3YT5je5TLzIY1IcdAcvRrDiKWEc/Hj4FSQFrxxvutu17nzJ/HlwHox0dQA==", "0968354148", false, "", false, new DateTime(2022, 4, 9, 11, 20, 3, 905, DateTimeKind.Local).AddTicks(6510), "/upload/avatar/admin1.jpg", "admin123" });
        }
    }
}
