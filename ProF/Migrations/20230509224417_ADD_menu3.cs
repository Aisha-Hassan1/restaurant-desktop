using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProF.Migrations
{
    /// <inheritdoc />
    public partial class ADD_menu3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_menu_menu_id",
                table: "items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_menu",
                table: "menu");

            migrationBuilder.RenameTable(
                name: "menu",
                newName: "menus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_menus",
                table: "menus",
                column: "menu_id");

            migrationBuilder.AddForeignKey(
                name: "FK_items_menus_menu_id",
                table: "items",
                column: "menu_id",
                principalTable: "menus",
                principalColumn: "menu_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_menus_menu_id",
                table: "items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_menus",
                table: "menus");

            migrationBuilder.RenameTable(
                name: "menus",
                newName: "menu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_menu",
                table: "menu",
                column: "menu_id");

            migrationBuilder.AddForeignKey(
                name: "FK_items_menu_menu_id",
                table: "items",
                column: "menu_id",
                principalTable: "menu",
                principalColumn: "menu_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
