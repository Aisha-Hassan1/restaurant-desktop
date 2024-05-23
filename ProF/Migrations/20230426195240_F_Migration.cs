using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProF.Migrations
{
    /// <inheritdoc />
    public partial class F_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    Cate_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cate_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.Cate_Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Payment_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type_Payment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    order_num = table.Column<int>(type: "int", nullable: false),
                    Total_payment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Payment_Id);
                });

            migrationBuilder.CreateTable(
                name: "Registeration_USER_s",
                columns: table => new
                {
                    Register_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    table_num = table.Column<int>(type: "int", nullable: false),
                    Register_DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registeration_USER_s", x => x.Register_id);
                });

            migrationBuilder.CreateTable(
                name: "Searches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recipe_num = table.Column<int>(type: "int", nullable: false),
                    Recipe_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Searches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    tatable_num = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.tatable_num);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    order_num = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Register_id = table.Column<int>(type: "int", nullable: false),
                    Recipes_Num = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_DateTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity_of_each_recipe = table.Column<int>(type: "int", nullable: false),
                    Registeration_USER_Register_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.order_num);
                    table.ForeignKey(
                        name: "FK_Orders_Registeration_USER_s_Registeration_USER_Register_id",
                        column: x => x.Registeration_USER_Register_id,
                        principalTable: "Registeration_USER_s",
                        principalColumn: "Register_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Registeration_USER_Table",
                columns: table => new
                {
                    Registeration_USER_sRegister_id = table.Column<int>(type: "int", nullable: false),
                    Tablestatable_num = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registeration_USER_Table", x => new { x.Registeration_USER_sRegister_id, x.Tablestatable_num });
                    table.ForeignKey(
                        name: "FK_Registeration_USER_Table_Registeration_USER_s_Registeration_USER_sRegister_id",
                        column: x => x.Registeration_USER_sRegister_id,
                        principalTable: "Registeration_USER_s",
                        principalColumn: "Register_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registeration_USER_Table_Tables_Tablestatable_num",
                        column: x => x.Tablestatable_num,
                        principalTable: "Tables",
                        principalColumn: "tatable_num",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderPayment",
                columns: table => new
                {
                    Ordersorder_num = table.Column<int>(type: "int", nullable: false),
                    PaymentsPayment_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPayment", x => new { x.Ordersorder_num, x.PaymentsPayment_Id });
                    table.ForeignKey(
                        name: "FK_OrderPayment_Orders_Ordersorder_num",
                        column: x => x.Ordersorder_num,
                        principalTable: "Orders",
                        principalColumn: "order_num",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderPayment_Payments_PaymentsPayment_Id",
                        column: x => x.PaymentsPayment_Id,
                        principalTable: "Payments",
                        principalColumn: "Payment_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Recipe_num = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recipe_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recipe_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recip_Cost = table.Column<float>(type: "real", nullable: false),
                    Recipe_image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Evaluation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    order_num = table.Column<int>(type: "int", nullable: false),
                    CategoryCate_Id = table.Column<int>(type: "int", nullable: false),
                    SearchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Recipe_num);
                    table.ForeignKey(
                        name: "FK_Recipes_Categorys_CategoryCate_Id",
                        column: x => x.CategoryCate_Id,
                        principalTable: "Categorys",
                        principalColumn: "Cate_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recipes_Orders_order_num",
                        column: x => x.order_num,
                        principalTable: "Orders",
                        principalColumn: "order_num",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recipes_Searches_SearchId",
                        column: x => x.SearchId,
                        principalTable: "Searches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderPayment_PaymentsPayment_Id",
                table: "OrderPayment",
                column: "PaymentsPayment_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Registeration_USER_Register_id",
                table: "Orders",
                column: "Registeration_USER_Register_id");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryCate_Id",
                table: "Recipes",
                column: "CategoryCate_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_order_num",
                table: "Recipes",
                column: "order_num");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_SearchId",
                table: "Recipes",
                column: "SearchId");

            migrationBuilder.CreateIndex(
                name: "IX_Registeration_USER_Table_Tablestatable_num",
                table: "Registeration_USER_Table",
                column: "Tablestatable_num");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderPayment");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Registeration_USER_Table");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Searches");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "Registeration_USER_s");
        }
    }
}
