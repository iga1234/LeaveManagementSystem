using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82da3d2b-b424-4c47-b2f4-8c324b42a696",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f725accc-3cf1-4d43-8872-5636f9c6756a", "AQAAAAIAAYagAAAAENpYT42JllXjmJxsjoIiuYxx/j7uGZiSWWGr0UEbtn3+PfChokOJvBorAHRodb3FbA==", "eca751f1-7ec3-4b34-9219-0ed0dc2ef915" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82da3d2b-b424-4c47-b2f4-8c324b42a696",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdc605e3-b400-4a0b-a335-c42f4fa2eeb1", "AQAAAAIAAYagAAAAEJ0Nz22KK3OMoY5hrct/7YJ5+AmSxkH3T4Qsf6C3kPw8rSeVbJ2Ka33TwYCEJJdNjg==", "e9c4c0d2-6623-446b-9c58-e126bd2b72bc" });
        }
    }
}
