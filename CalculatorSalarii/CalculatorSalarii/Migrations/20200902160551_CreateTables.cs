using Microsoft.EntityFrameworkCore.Migrations;

namespace CalculatorSalarii.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParametriLunari",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcentCAS = table.Column<double>(nullable: false),
                    ProcentCASS = table.Column<double>(nullable: false),
                    ProcentImpozit = table.Column<double>(nullable: false),
                    ProcentCAM = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParametriLunari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatPlata",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AngajatId = table.Column<int>(nullable: true),
                    ContributieCAS = table.Column<int>(nullable: false),
                    ContributieCASS = table.Column<int>(nullable: false),
                    DeducerePersonala = table.Column<int>(nullable: false),
                    SumaImpozit = table.Column<int>(nullable: false),
                    SumaCAM = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatPlata", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatPlata_Angajat_AngajatId",
                        column: x => x.AngajatId,
                        principalTable: "Angajat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StatPlata_AngajatId",
                table: "StatPlata",
                column: "AngajatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParametriLunari");

            migrationBuilder.DropTable(
                name: "StatPlata");
        }
    }
}
