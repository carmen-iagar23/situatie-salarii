using Microsoft.EntityFrameworkCore.Migrations;
using System.Data.SqlTypes;

namespace CalculatorSalarii.Migrations
{
    public partial class CreateTableAngajati : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Angajat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(maxLength: 50, nullable: false),
                    Prenume = table.Column<string>(maxLength: 50, nullable: false),
                    VenitBrut = table.Column<decimal>(nullable: false),
                    IsServiciuDeBaza = table.Column<bool>(nullable: false),
                    NrPersoaneInIntretinere = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Angajat", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Angajat");
        }
    }
}
