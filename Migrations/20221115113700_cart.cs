using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_Api.Migrations
{
    public partial class cart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Place",
                table: "clients",
                newName: "Price");

            migrationBuilder.CreateTable(
                name: "carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Id = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_carts_clients_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "clients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_carts_Product_Id",
                table: "carts",
                column: "Product_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carts");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "clients",
                newName: "Place");
        }
    }
}
