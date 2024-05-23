using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProF.Migrations
{
    /// <inheritdoc />
    public partial class ADD_menu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "menu_id",
                table: "items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "menu",
                columns: table => new
                {
                    menu_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    menu_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    menu_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    menu_Cost = table.Column<float>(type: "real", nullable: false),
                    menu_image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menu", x => x.menu_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_items_menu_id",
                table: "items",
                column: "menu_id");

            migrationBuilder.AddForeignKey(
                name: "FK_items_menu_menu_id",
                table: "items",
                column: "menu_id",
                principalTable: "menu",
                principalColumn: "menu_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_menu_menu_id",
                table: "items");

            migrationBuilder.DropTable(
                name: "menu");

            migrationBuilder.DropIndex(
                name: "IX_items_menu_id",
                table: "items");

            migrationBuilder.DropColumn(
                name: "menu_id",
                table: "items");
        }
    }
}
