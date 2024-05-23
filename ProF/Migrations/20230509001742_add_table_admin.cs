using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProF.Migrations
{
    /// <inheritdoc />
    public partial class add_table_admin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "login_admins",
                columns: table => new
                {
                    admin_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    item_id = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    passward = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_login_admins", x => x.admin_id);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    item_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    item_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    item_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    item_Cost = table.Column<float>(type: "real", nullable: false),
                    item_image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    login_adminadmin_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.item_id);
                    table.ForeignKey(
                        name: "FK_items_login_admins_login_adminadmin_id",
                        column: x => x.login_adminadmin_id,
                        principalTable: "login_admins",
                        principalColumn: "admin_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_items_login_adminadmin_id",
                table: "items",
                column: "login_adminadmin_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "login_admins");
        }
    }
}
