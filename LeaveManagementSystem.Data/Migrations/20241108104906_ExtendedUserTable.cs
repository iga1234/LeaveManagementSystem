using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82da3d2b-b424-4c47-b2f4-8c324b42a696",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8f21c0c-cb49-495d-8bcc-4a488ffa3cc4", new DateOnly(1950, 12, 1), "Deafault", "Admin", "AQAAAAIAAYagAAAAEGG8JN8xTHQZ2daXBzi8xuwyFKPrKKuKZaxh/vNVCr3ckXgs8ZMp6MFrW1LJI6UwQA==", "b1239acd-3d71-429a-a28b-f4c8d6c45b53" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82da3d2b-b424-4c47-b2f4-8c324b42a696",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29385bd1-d1ac-4ffe-8ebd-6d11a46b85f5", "AQAAAAIAAYagAAAAEM56io/CNV3zBxhaHnbyt9jeEGol1enZKE/iUORnrv2oWdA++4K8R/UlltrEVp+zhg==", "bf5dba7c-7fb7-466f-9346-072417046d6c" });
        }
    }
}
