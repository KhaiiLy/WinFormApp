using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormApp.Migrations
{
    /// <inheritdoc />
    public partial class FixTypoInPersonObject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthData",
                table: "People",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "Enamil",
                table: "Companies",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "CIN",
                table: "Companies",
                newName: "CompanyIdNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "People",
                newName: "BirthData");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Companies",
                newName: "Enamil");

            migrationBuilder.RenameColumn(
                name: "CompanyIdNumber",
                table: "Companies",
                newName: "CIN");
        }
    }
}
