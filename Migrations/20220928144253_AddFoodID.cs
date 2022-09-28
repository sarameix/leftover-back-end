using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace leftover_backend.Migrations
{
    public partial class AddFoodID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FoodID",
                table: "ingredients",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodID",
                table: "ingredients");
        }
    }
}
