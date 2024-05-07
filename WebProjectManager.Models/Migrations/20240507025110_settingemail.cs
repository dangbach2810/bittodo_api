using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProjectManager.Models.Migrations
{
    public partial class settingemail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("d13da31f-d60d-44f4-bd49-10ef6a24354b") });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d13da31f-d60d-44f4-bd49-10ef6a24354b"));

            migrationBuilder.CreateTable(
                name: "SettingEmail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SendEmail = table.Column<bool>(type: "bit", nullable: true),
                    SendDaily = table.Column<bool>(type: "bit", nullable: true),
                    SendWeekly = table.Column<bool>(type: "bit", nullable: true),
                    SendMonthly = table.Column<bool>(type: "bit", nullable: true),
                    SendYearly = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingEmail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SettingEmail_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SettingEmail_UserId",
                table: "SettingEmail",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SettingEmail");

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("d13da31f-d60d-44f4-bd49-10ef6a24354b") });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "IsActive", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "199cabd9-9bbd-4acb-8490-ee0994ac2e11", "Administrator role", true, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedOn", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Gender", "IsActive", "IsVerification", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedOn", "UrlAvatar", "UserName" },
                values: new object[] { new Guid("d13da31f-d60d-44f4-bd49-10ef6a24354b"), 0, "Đà Nẵng", "f79b747c-b715-4fe8-8e64-a2e824089d53", new DateTime(2024, 5, 3, 14, 5, 48, 446, DateTimeKind.Local).AddTicks(660), new DateTime(2000, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Nam", true, true, true, "Tran Thanh", false, null, "ADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAENDriReY2dKPk0M2ji+L8aTEpfQAy8CVf+/2xq0Uf0NypJYSBch06DD7GWaa28u5FA==", "0968354148", false, "", false, new DateTime(2024, 5, 3, 14, 5, 48, 446, DateTimeKind.Local).AddTicks(669), "/upload/avatar/admin1.jpg", "admin123" });
        }
    }
}
