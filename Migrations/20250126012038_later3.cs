using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UyariSoftBk.Migrations
{
    public partial class later3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdGitHub",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IdImages",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdGitHub",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdImages",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
