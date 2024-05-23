using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProF.Migrations
{
    /// <inheritdoc />
    public partial class update_manu_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "menu_name",
                table: "menus",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "menu_name",
                table: "menus");
        }
    }
}
