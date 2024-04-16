using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AGREGAMENTO.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agregados",
                columns: table => new
                {
                    IdSerede = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cargo = table.Column<int>(type: "int", nullable: false),
                    Situacao = table.Column<int>(type: "int", nullable: false),
                    Termo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<int>(type: "int", nullable: false),
                    SituacaoColaborador = table.Column<int>(type: "int", nullable: false),
                    Pagamento = table.Column<int>(type: "int", nullable: false),
                    GestorCentroDeCusto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agregados", x => x.IdSerede);
                });

            migrationBuilder.CreateTable(
                name: "Fabricantes",
                columns: table => new
                {
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    IdSerede = table.Column<int>(type: "int", nullable: false),
                    DataDaAcao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cadastro = table.Column<int>(type: "int", nullable: false),
                    Edicao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExclusaoLogicaDoFabricante = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricantes", x => x.Ativo);
                });

            migrationBuilder.CreateTable(
                name: "Valores",
                columns: table => new
                {
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataDaAcao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdSerede = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valores", x => x.Estado);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agregados");

            migrationBuilder.DropTable(
                name: "Fabricantes");

            migrationBuilder.DropTable(
                name: "Valores");
        }
    }
}
