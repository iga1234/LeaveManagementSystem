using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixSupervisorProblem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b305d58-7143-4889-ad2e-8271f5c63d7c",
                column: "Name",
                value: "Supervisor");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82da3d2b-b424-4c47-b2f4-8c324b42a696",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b0cf171-6e15-4fcb-9bac-47370747ab91", "AQAAAAIAAYagAAAAEDT/XPK47KxyvokYXtB6Esew+MuekRMa04be+Rl5xItO0Z2y+xPt0IHlF2ac/RlHgQ==", "375a11d0-3794-44bc-b842-98921d584cc4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b305d58-7143-4889-ad2e-8271f5c63d7c",
                column: "Name",
                value: "Supervisior");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82da3d2b-b424-4c47-b2f4-8c324b42a696",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8f21c0c-cb49-495d-8bcc-4a488ffa3cc4", "AQAAAAIAAYagAAAAEGG8JN8xTHQZ2daXBzi8xuwyFKPrKKuKZaxh/vNVCr3ckXgs8ZMp6MFrW1LJI6UwQA==", "b1239acd-3d71-429a-a28b-f4c8d6c45b53" });
        }
    }
}
