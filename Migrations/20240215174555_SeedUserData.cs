using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TryMVCwithORM.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Email", "Password" },
                values: new object[] { 1, "John Doe", "john.doe@mail.com", "123456" }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(table: "Users", keyColumn: "Id", keyValue: 1);
        }
    }
}
