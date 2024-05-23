using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProF.Migrations
{
    /// <inheritdoc />
    public partial class f_Migration6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "stars",
                table: "items",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "stars",
                table: "items");
        }
    }
}
