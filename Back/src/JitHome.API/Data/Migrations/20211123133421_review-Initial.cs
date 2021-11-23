using Microsoft.EntityFrameworkCore.Migrations;

namespace JitHome.API.Data.Migrations
{
    public partial class reviewInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "GrupoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "UnidadeMedidaId",
                table: "Produtos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Produtos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GrupoId",
                table: "Produtos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnidadeMedidaId",
                table: "Produtos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
