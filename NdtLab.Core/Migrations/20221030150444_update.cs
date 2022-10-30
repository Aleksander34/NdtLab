using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NdtLab.Core.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PartTank",
                table: "Tanks",
                newName: "Part");

            migrationBuilder.RenameColumn(
                name: "CategoryGOST",
                table: "Requests",
                newName: "CategoryGost");

            migrationBuilder.RenameColumn(
                name: "TypeQualification",
                table: "Qualifications",
                newName: "Type");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Part",
                table: "Tanks",
                newName: "PartTank");

            migrationBuilder.RenameColumn(
                name: "CategoryGost",
                table: "Requests",
                newName: "CategoryGOST");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Qualifications",
                newName: "TypeQualification");
        }
    }
}
