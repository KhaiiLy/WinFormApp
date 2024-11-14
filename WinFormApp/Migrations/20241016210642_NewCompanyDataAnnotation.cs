using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormApp.Migrations
{
    /// <inheritdoc />
    public partial class NewCompanyDataAnnotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "CompanyIdNumber",
                table: "Companies",
                newName: "CompanyIDNumber");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyIDNumber",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "CompanyIDNumber",
                table: "Companies",
                newName: "CompanyIdNumber");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyIdNumber",
                table: "Companies",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "CompanyIdNumber");
        }
    }
}
