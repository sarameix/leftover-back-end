using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace leftover_backend.Migrations
{
    public partial class IngredientAddImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "ingredients",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "ingredients");
        }
    }
}
