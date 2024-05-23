using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProF.Migrations
{
    /// <inheritdoc />
    public partial class updata_table_admin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_login_admins_login_adminadmin_id",
                table: "items");

            migrationBuilder.DropColumn(
                name: "item_id",
                table: "login_admins");

            migrationBuilder.RenameColumn(
                name: "login_adminadmin_id",
                table: "items",
                newName: "adminID");

            migrationBuilder.RenameIndex(
                name: "IX_items_login_adminadmin_id",
                table: "items",
                newName: "IX_items_adminID");

            migrationBuilder.AddForeignKey(
                name: "FK_items_login_admins_adminID",
                table: "items",
                column: "adminID",
                principalTable: "login_admins",
                principalColumn: "admin_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_login_admins_adminID",
                table: "items");

            migrationBuilder.RenameColumn(
                name: "adminID",
                table: "items",
                newName: "login_adminadmin_id");

            migrationBuilder.RenameIndex(
                name: "IX_items_adminID",
                table: "items",
                newName: "IX_items_login_adminadmin_id");

            migrationBuilder.AddColumn<int>(
                name: "item_id",
                table: "login_admins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_items_login_admins_login_adminadmin_id",
                table: "items",
                column: "login_adminadmin_id",
                principalTable: "login_admins",
                principalColumn: "admin_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
