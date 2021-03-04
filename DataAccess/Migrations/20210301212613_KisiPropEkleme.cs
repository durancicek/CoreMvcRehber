using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class KisiPropEkleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EvTelefon",
                table: "Kisiler",
                newName: "ilce");

            migrationBuilder.AddColumn<string>(
                name: "Firma",
                table: "Kisiler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SabitTelefon",
                table: "Kisiler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "il",
                table: "Kisiler",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Firma",
                table: "Kisiler");

            migrationBuilder.DropColumn(
                name: "SabitTelefon",
                table: "Kisiler");

            migrationBuilder.DropColumn(
                name: "il",
                table: "Kisiler");

            migrationBuilder.RenameColumn(
                name: "ilce",
                table: "Kisiler",
                newName: "EvTelefon");
        }
    }
}
