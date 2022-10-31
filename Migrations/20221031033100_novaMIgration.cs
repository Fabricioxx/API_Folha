using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Folha.Migrations
{
    public partial class novaMIgration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Salario",
                table: "FolhaPagamentos",
                newName: "SalarioBruto");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "FolhaPagamentos",
                newName: "CriadoEm");

            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "FolhaPagamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Fgts",
                table: "FolhaPagamentos",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HorasTrabalhadas",
                table: "FolhaPagamentos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Mes",
                table: "FolhaPagamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "ValorHora",
                table: "FolhaPagamentos",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ano",
                table: "FolhaPagamentos");

            migrationBuilder.DropColumn(
                name: "Fgts",
                table: "FolhaPagamentos");

            migrationBuilder.DropColumn(
                name: "HorasTrabalhadas",
                table: "FolhaPagamentos");

            migrationBuilder.DropColumn(
                name: "Mes",
                table: "FolhaPagamentos");

            migrationBuilder.DropColumn(
                name: "ValorHora",
                table: "FolhaPagamentos");

            migrationBuilder.RenameColumn(
                name: "SalarioBruto",
                table: "FolhaPagamentos",
                newName: "Salario");

            migrationBuilder.RenameColumn(
                name: "CriadoEm",
                table: "FolhaPagamentos",
                newName: "Data");
        }
    }
}
