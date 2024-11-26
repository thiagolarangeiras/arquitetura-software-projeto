using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Custos.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Custo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FilmeId = table.Column<int>(type: "INTEGER", nullable: false),
                    ValorMidiaFisica = table.Column<decimal>(type: "TEXT", nullable: false),
                    ValorBilheteCinema = table.Column<decimal>(type: "TEXT", nullable: false),
                    ValorProducao = table.Column<decimal>(type: "TEXT", nullable: false),
                    ValorBilheteria = table.Column<decimal>(type: "TEXT", nullable: false),
                    ValorTotalArecadado = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Custo", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Custo");
        }
    }
}
