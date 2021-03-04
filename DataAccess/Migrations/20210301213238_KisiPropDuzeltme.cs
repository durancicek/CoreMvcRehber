using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class KisiPropDuzeltme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "Kisiler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
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

            migrationBuilder.AddColumn<string>(
                name: "ilce",
                table: "Kisiler",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adres",
                table: "Kisiler");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Kisiler");

            migrationBuilder.DropColumn(
                name: "SabitTelefon",
                table: "Kisiler");

            migrationBuilder.DropColumn(
                name: "il",
                table: "Kisiler");

            migrationBuilder.DropColumn(
                name: "ilce",
                table: "Kisiler");
        }
    }
}
