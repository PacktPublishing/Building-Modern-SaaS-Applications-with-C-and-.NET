using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoodHabits.Database.Migrations
{
    /// <inheritdoc />
    public partial class MultiTenant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TenantName",
                table: "Habits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 100,
                column: "TenantName",
                value: "CloudSphere");

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 101,
                column: "TenantName",
                value: "CloudSphere");

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 102,
                column: "TenantName",
                value: "CloudSphere");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantName",
                table: "Habits");
        }
    }
}
