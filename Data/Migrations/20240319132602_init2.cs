using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d95d3300-1d28-4340-b849-353bf3ec7ac1", null, "User", "User" },
                    { "ebc6eabf-9fac-47c2-94fe-b5888da62f5b", null, "Administrator", "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aff251bb-8536-4bf7-96f0-3274f09f2052", 0, "27cf316b-4fa7-411a-bbdd-cc594394210a", "admin@bovision.se", false, false, null, "admin@bovision.se", "admin@bovision.se", "AQAAAAIAAYagAAAAEMSWX7t0MmsDzbvZ7vKgGKfO2mUUyMGcm+P8Ej82Ylry5sYtL1X+gsRV3TjmNY2BBw==", null, false, "6cddcb7a-6eee-4913-b232-e53f15077cd5", false, "admin@bovision.se" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ebc6eabf-9fac-47c2-94fe-b5888da62f5b", "aff251bb-8536-4bf7-96f0-3274f09f2052" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d95d3300-1d28-4340-b849-353bf3ec7ac1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebc6eabf-9fac-47c2-94fe-b5888da62f5b", "aff251bb-8536-4bf7-96f0-3274f09f2052" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebc6eabf-9fac-47c2-94fe-b5888da62f5b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aff251bb-8536-4bf7-96f0-3274f09f2052");
        }
    }
}
