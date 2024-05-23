using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProF.Migrations
{
    /// <inheritdoc />
    public partial class ADD_menu2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "menu_Cost",
                table: "menu");

            migrationBuilder.DropColumn(
                name: "menu_Description",
                table: "menu");

            migrationBuilder.DropColumn(
                name: "menu_Name",
                table: "menu");

            migrationBuilder.DropColumn(
                name: "menu_image",
                table: "menu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "menu_Cost",
                table: "menu",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "menu_Description",
                table: "menu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "menu_Name",
                table: "menu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "menu_image",
                table: "menu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
