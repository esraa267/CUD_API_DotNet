using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_Api.Migrations
{
    public partial class UpdateClientTBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "clients",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "clients");
        }
    }
}
