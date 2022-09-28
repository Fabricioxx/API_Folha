using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Folha.Migrations
{
    public partial class mmmgratin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Funcionarios",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Celular",
                table: "Funcionarios",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Funcionarios",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Salario",
                table: "Funcionarios",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Salario",
                table: "Funcionarios");
        }
    }
}
