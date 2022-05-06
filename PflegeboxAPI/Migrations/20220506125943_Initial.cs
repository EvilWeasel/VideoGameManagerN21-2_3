using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PflegeboxAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adressen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Nachname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Strasse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hausnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ort = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adressen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PflegeboxAntraege",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpfaengerAdresseId = table.Column<int>(type: "int", nullable: true),
                    LieferAdresseId = table.Column<int>(type: "int", nullable: true),
                    IstPrivatVersichert = table.Column<bool>(type: "bit", nullable: false),
                    VersichertenNummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Krankenkasse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoxArt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PflegeboxAntraege", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PflegeboxAntraege_Adressen_EmpfaengerAdresseId",
                        column: x => x.EmpfaengerAdresseId,
                        principalTable: "Adressen",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PflegeboxAntraege_Adressen_LieferAdresseId",
                        column: x => x.LieferAdresseId,
                        principalTable: "Adressen",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PflegeboxAntraege_EmpfaengerAdresseId",
                table: "PflegeboxAntraege",
                column: "EmpfaengerAdresseId");

            migrationBuilder.CreateIndex(
                name: "IX_PflegeboxAntraege_LieferAdresseId",
                table: "PflegeboxAntraege",
                column: "LieferAdresseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PflegeboxAntraege");

            migrationBuilder.DropTable(
                name: "Adressen");
        }
    }
}
