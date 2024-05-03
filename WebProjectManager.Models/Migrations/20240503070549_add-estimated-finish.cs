using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProjectManager.Models.Migrations
{
    public partial class addestimatedfinish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("d21c6259-633e-45aa-b113-9051ed23edd7") });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d21c6259-633e-45aa-b113-9051ed23edd7"));

            migrationBuilder.AddColumn<DateTime>(
                name: "EstimatedFinish",
                table: "Cards",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("d13da31f-d60d-44f4-bd49-10ef6a24354b") });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "199cabd9-9bbd-4acb-8490-ee0994ac2e11");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedOn", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Gender", "IsActive", "IsVerification", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedOn", "UrlAvatar", "UserName" },
                values: new object[] { new Guid("d13da31f-d60d-44f4-bd49-10ef6a24354b"), 0, "Đà Nẵng", "f79b747c-b715-4fe8-8e64-a2e824089d53", new DateTime(2024, 5, 3, 14, 5, 48, 446, DateTimeKind.Local).AddTicks(660), new DateTime(2000, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Nam", true, true, true, "Tran Thanh", false, null, "ADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAENDriReY2dKPk0M2ji+L8aTEpfQAy8CVf+/2xq0Uf0NypJYSBch06DD7GWaa28u5FA==", "0968354148", false, "", false, new DateTime(2024, 5, 3, 14, 5, 48, 446, DateTimeKind.Local).AddTicks(669), "/upload/avatar/admin1.jpg", "admin123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("d13da31f-d60d-44f4-bd49-10ef6a24354b") });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d13da31f-d60d-44f4-bd49-10ef6a24354b"));

            migrationBuilder.DropColumn(
                name: "EstimatedFinish",
                table: "Cards");

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
    }
}
