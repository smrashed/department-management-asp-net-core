using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepartmentManagement.Migrations
{
    public partial class Changing_chairmanId2_to_chairmanId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Person_ChairmanId2",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "ChairmanId2",
                table: "Departments",
                newName: "ChairmanId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_ChairmanId2",
                table: "Departments",
                newName: "IX_Departments_ChairmanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Person_ChairmanId",
                table: "Departments",
                column: "ChairmanId",
                principalTable: "Person",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Person_ChairmanId",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "ChairmanId",
                table: "Departments",
                newName: "ChairmanId2");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_ChairmanId",
                table: "Departments",
                newName: "IX_Departments_ChairmanId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Person_ChairmanId2",
                table: "Departments",
                column: "ChairmanId2",
                principalTable: "Person",
                principalColumn: "Id");
        }
    }
}
