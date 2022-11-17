using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_Api.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carts_clients_Product_Id",
                table: "carts");

            migrationBuilder.DropIndex(
                name: "IX_carts_Product_Id",
                table: "carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clients",
                table: "clients");

            migrationBuilder.DropColumn(
                name: "Product_Id",
                table: "carts");

            migrationBuilder.RenameTable(
                name: "clients",
                newName: "products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CartProduct",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartProduct", x => new { x.CartId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CartProduct_carts_CartId",
                        column: x => x.CartId,
                        principalTable: "carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartProduct_products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartProduct_ProductsId",
                table: "CartProduct",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "clients");

            migrationBuilder.AddColumn<int>(
                name: "Product_Id",
                table: "carts",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_clients",
                table: "clients",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_carts_Product_Id",
                table: "carts",
                column: "Product_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_carts_clients_Product_Id",
                table: "carts",
                column: "Product_Id",
                principalTable: "clients",
                principalColumn: "Id");
        }
    }
}
