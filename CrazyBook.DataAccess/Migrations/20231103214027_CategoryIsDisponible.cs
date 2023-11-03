using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrazyBook.DataAccess.Migrations
{
    public partial class CategoryIsDisponible : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDisponible",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDisponible",
                table: "Categories");
        }
    }
}
