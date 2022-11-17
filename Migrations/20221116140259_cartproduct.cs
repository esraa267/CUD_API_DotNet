using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_Api.Migrations
{
    public partial class cartproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_products_ProductsId",
                table: "CartProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartProduct",
                table: "CartProduct");

            migrationBuilder.DropIndex(
                name: "IX_CartProduct_CartId",
                table: "CartProduct");

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "CartProduct",
                newName: "ProductId1");

            migrationBuilder.RenameIndex(
                name: "IX_CartProduct_ProductsId",
                table: "CartProduct",
                newName: "IX_CartProduct_ProductId1");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "CartProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CartId1",
                table: "CartProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartProduct",
                table: "CartProduct",
                columns: new[] { "CartId", "ProductId" });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartProduct_CartId1",
                table: "CartProduct",
                column: "CartId1");

            migrationBuilder.CreateIndex(
                name: "IX_CartProduct_ProductId",
                table: "CartProduct",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_carts_CartId1",
                table: "CartProduct",
                column: "CartId1",
                principalTable: "carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_products_ProductId",
                table: "CartProduct",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_products_ProductId1",
                table: "CartProduct",
                column: "ProductId1",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_carts_CartId1",
                table: "CartProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_products_ProductId",
                table: "CartProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_products_ProductId1",
                table: "CartProduct");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartProduct",
                table: "CartProduct");

            migrationBuilder.DropIndex(
                name: "IX_CartProduct_CartId1",
                table: "CartProduct");

            migrationBuilder.DropIndex(
                name: "IX_CartProduct_ProductId",
                table: "CartProduct");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "CartProduct");

            migrationBuilder.DropColumn(
                name: "CartId1",
                table: "CartProduct");

            migrationBuilder.RenameColumn(
                name: "ProductId1",
                table: "CartProduct",
                newName: "ProductsId");

            migrationBuilder.RenameIndex(
                name: "IX_CartProduct_ProductId1",
                table: "CartProduct",
                newName: "IX_CartProduct_ProductsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartProduct",
                table: "CartProduct",
                columns: new[] { "CartId", "ProductsId" });

            migrationBuilder.CreateIndex(
                name: "IX_CartProduct_CartId",
                table: "CartProduct",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_products_ProductsId",
                table: "CartProduct",
                column: "ProductsId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
