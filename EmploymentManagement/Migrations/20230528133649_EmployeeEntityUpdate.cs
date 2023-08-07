using Microsoft.EntityFrameworkCore.Migrations;

namespace EmploymentManagement.Migrations
{
    public partial class EmployeeEntityUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoPath",
                table: "Employees",
                newName: "PhotoName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoName",
                table: "Employees",
                newName: "PhotoPath");
        }
    }
}
