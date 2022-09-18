using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepartmentManagement.Migrations
{
    public partial class Added_imageUrl_to_person : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Person");
        }
    }
}
