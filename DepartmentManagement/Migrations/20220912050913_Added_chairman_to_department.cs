using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepartmentManagement.Migrations
{
    public partial class Added_chairman_to_department : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Departments_DepartmentId",
                table: "Person");

            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TermEnd",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TermStart",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChairmanId2",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ChairmanId2",
                table: "Departments",
                column: "ChairmanId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Person_ChairmanId2",
                table: "Departments",
                column: "ChairmanId2",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Departments_DepartmentId",
                table: "Person",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Person_ChairmanId2",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Departments_DepartmentId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Departments_ChairmanId2",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Designation",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "TermEnd",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "TermStart",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "ChairmanId2",
                table: "Departments");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Departments_DepartmentId",
                table: "Person",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
