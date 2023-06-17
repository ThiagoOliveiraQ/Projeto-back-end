using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace calculodeequipamentos.Migrations
{
    /// <inheritdoc />
    public partial class Equipamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipamentos",
                columns: table => new
                {
                    Nome = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Potencia = table.Column<int>(type: "int", nullable: false),
                    TempoDeUso = table.Column<int>(type: "int", nullable: false),
                    Consumo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamentos", x => x.Nome);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipamentos");
        }
    }
}
