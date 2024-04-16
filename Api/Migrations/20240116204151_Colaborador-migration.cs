using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AGREGAMENTO.Migrations
{
    public partial class Colaboradormigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Edicao",
                table: "Fabricantes");

            migrationBuilder.DropColumn(
                name: "ExclusaoLogicaDoFabricante",
                table: "Fabricantes");

            migrationBuilder.RenameColumn(
                name: "Cadastro",
                table: "Fabricantes",
                newName: "Nome");

            migrationBuilder.CreateTable(
                name: "Colaboradores",
                columns: table => new
                {
                    IdSerede = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SituacaoDoColaborador = table.Column<bool>(type: "bit", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PIS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CentroDeCusto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gestor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaboradores", x => x.IdSerede);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colaboradores");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Fabricantes",
                newName: "Cadastro");

            migrationBuilder.AddColumn<string>(
                name: "Edicao",
                table: "Fabricantes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExclusaoLogicaDoFabricante",
                table: "Fabricantes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
