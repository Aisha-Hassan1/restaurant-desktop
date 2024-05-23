using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProF.Migrations
{
    /// <inheritdoc />
    public partial class delet_menu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_menus_menu_id",
                table: "items");

            migrationBuilder.DropTable(
                name: "menus");

            migrationBuilder.DropIndex(
                name: "IX_items_menu_id",
                table: "items");

            migrationBuilder.DropColumn(
                name: "menu_id",
                table: "items");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "menu_id",
                table: "items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "menus",
                columns: table => new
                {
                    menu_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    menu_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menus", x => x.menu_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_items_menu_id",
                table: "items",
                column: "menu_id");

            migrationBuilder.AddForeignKey(
                name: "FK_items_menus_menu_id",
                table: "items",
                column: "menu_id",
                principalTable: "menus",
                principalColumn: "menu_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
