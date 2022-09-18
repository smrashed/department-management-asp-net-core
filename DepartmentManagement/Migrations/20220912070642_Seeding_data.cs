using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepartmentManagement.Migrations
{
    public partial class Seeding_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "ChairmanId", "Description", "Name" },
                values: new object[] { 1, null, "Dept. of CSE, Islamic University, kushtia", "CSE" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "CGPA", "DepartmentId", "Discriminator", "Email", "EnrollmentDate", "FirstName", "ImageUrl", "LastName", "PhoneNumber", "Semister", "Session" },
                values: new object[,]
                {
                    { 1147, null, 1, "Student", "smrashed@abc.com", new DateTime(2015, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "SM", null, "Rashedul Islam", "+8801712345678", "1st", "14-15" },
                    { 1148, null, 1, "Student", "mamun77@abc.com", new DateTime(2015, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Md", null, "Abdullah Al-mamun", "+8801512343678", "1st", "14-15" },
                    { 1149, null, 1, "Student", "nibir.hossain@xyz.com", new DateTime(2015, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nibir", null, "Hossain", "+8801912345679", "1st", "14-15" },
                    { 1150, null, 1, "Student", "tanzim.tetumir@abc.com", new DateTime(2015, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanzim", null, "Tetumir", "+8801612345778", "1st", "14-15" },
                    { 1151, null, 1, "Student", "jakushamim@xyz.com", new DateTime(2015, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Md", null, "Shamim Hossain", "+8801312345671", "1st", "14-15" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Teacher_DepartmentId", "Designation", "Discriminator", "Email", "FirstName", "ImageUrl", "JoiningDate", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 110, 1, "Lecturer", "Teacher", "atikur.rahman111@abc.com", "Md. Atikur", null, new DateTime(2006, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rahman", "+8801555566678" },
                    { 111, 1, "Lecturer", "Teacher", "alamgir.hossain112@abc.com", "Md. Alamgir", null, new DateTime(2007, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hossain", "+8801543566676" },
                    { 220, 1, "Assistant Professor", "Teacher", "shohanur.rahman220@abc.com", "Md. Shohanur", null, new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rahman", "+8801666544479" },
                    { 221, 1, "Assistant Professor", "Teacher", "muzahidur.rahman221@abc.com", "Md. Muzahidur", null, new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rahman", "+8801666655681" },
                    { 330, 1, "Associate Professor", "Teacher", "aom.asaduzzaman330@abc.com", "A.O.M", null, new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asaduzzaman", "+8801666566856" },
                    { 331, 1, "Associate Professor", "Teacher", "robiul.islam331@abc.com", "Md", null, new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robiul Islam", "+8801666569958" },
                    { 440, 1, "Professor", "Teacher", "ahsanul.ambia440@abc.com", "Md. Ahsanul", null, new DateTime(1999, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ambia", "+8801666566688" },
                    { 441, 1, "Professor", "Teacher", "aktaruzzaman.babu441@xyz.com", "Md. Aktaruzzaman", null, new DateTime(2001, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Babu", "+8801999566672" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credit", "DepartmentId", "Name", "TeacherId" },
                values: new object[,]
                {
                    { "CSE-101", 3, 1, "Computer Fundamentals", 110 },
                    { "CSE-102", 3, 1, "C Programming", 111 },
                    { "CSE-103", 3, 1, "Mathematics-I", 220 },
                    { "CSE-104", 3, 1, "Electronics-I", 221 },
                    { "CSE-105", 3, 1, "Mathematics-II", 330 },
                    { "CSE-106", 3, 1, "Computer Architecture", 331 },
                    { "CSE-107", 3, 1, "Electronics-II", 440 },
                    { "CSE-108", 3, 1, "Statistics", 441 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "CSE-101");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "CSE-102");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "CSE-103");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "CSE-104");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "CSE-105");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "CSE-106");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "CSE-107");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "CSE-108");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
