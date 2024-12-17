using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f5ad335-de61-40d7-b74e-a82de680c9c2", null, "Administrator", "ADMINISTRATOR" },
                    { "3b305d58-7143-4889-ad2e-8271f5c63d7c", null, "Supervisior", "SUPERVISOR" },
                    { "e252e472-125b-4497-98f3-f9bed8a3ca27", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "82da3d2b-b424-4c47-b2f4-8c324b42a696", 0, "29385bd1-d1ac-4ffe-8ebd-6d11a46b85f5", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEM56io/CNV3zBxhaHnbyt9jeEGol1enZKE/iUORnrv2oWdA++4K8R/UlltrEVp+zhg==", null, false, "bf5dba7c-7fb7-466f-9346-072417046d6c", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0f5ad335-de61-40d7-b74e-a82de680c9c2", "82da3d2b-b424-4c47-b2f4-8c324b42a696" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b305d58-7143-4889-ad2e-8271f5c63d7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e252e472-125b-4497-98f3-f9bed8a3ca27");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0f5ad335-de61-40d7-b74e-a82de680c9c2", "82da3d2b-b424-4c47-b2f4-8c324b42a696" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f5ad335-de61-40d7-b74e-a82de680c9c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82da3d2b-b424-4c47-b2f4-8c324b42a696");
        }
    }
}
