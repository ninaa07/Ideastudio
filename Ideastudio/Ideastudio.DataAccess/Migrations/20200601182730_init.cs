using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ideastudio.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GlavniProjektant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImePrezime = table.Column<string>(maxLength: 100, nullable: false),
                    BrojLicence = table.Column<long>(nullable: false),
                    Zvanje = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlavniProjektant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InformacijeOLokaciji",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumIzdavanja = table.Column<DateTime>(nullable: false),
                    NamenaZemljista = table.Column<string>(maxLength: 255, nullable: false),
                    Zona = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacijeOLokaciji", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Objekat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojParcele = table.Column<long>(nullable: false),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objekat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VrstaPovrsine",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaPovrsine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LokacijskaDozvola",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojParcele = table.Column<long>(nullable: false),
                    PovrsinaParcele = table.Column<long>(nullable: false),
                    DatumIzdavanja = table.Column<DateTime>(nullable: false),
                    NazivObjekta = table.Column<string>(maxLength: 50, nullable: false),
                    InformacijeOLokacijiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LokacijskaDozvola", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LokacijskaDozvola_InformacijeOLokaciji_InformacijeOLokacijiId",
                        column: x => x.InformacijeOLokacijiId,
                        principalTable: "InformacijeOLokaciji",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prostorija",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    VrstaPovrsineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prostorija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prostorija_VrstaPovrsine_VrstaPovrsineId",
                        column: x => x.VrstaPovrsineId,
                        principalTable: "VrstaPovrsine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdejnoResenje",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumIzrade = table.Column<DateTime>(nullable: false),
                    GlavniProjektantId = table.Column<int>(nullable: false),
                    ObjekatId = table.Column<int>(nullable: false),
                    LokacijskaDozvolaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdejnoResenje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdejnoResenje_GlavniProjektant_GlavniProjektantId",
                        column: x => x.GlavniProjektantId,
                        principalTable: "GlavniProjektant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IdejnoResenje_LokacijskaDozvola_LokacijskaDozvolaId",
                        column: x => x.LokacijskaDozvolaId,
                        principalTable: "LokacijskaDozvola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IdejnoResenje_Objekat_ObjekatId",
                        column: x => x.ObjekatId,
                        principalTable: "Objekat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjekatZaGradjevinskuDozvolu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    DatumIzrade = table.Column<DateTime>(nullable: false),
                    IdejnoResenjeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjekatZaGradjevinskuDozvolu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjekatZaGradjevinskuDozvolu_IdejnoResenje_IdejnoResenjeId",
                        column: x => x.IdejnoResenjeId,
                        principalTable: "IdejnoResenje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Povrsina",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Oznaka = table.Column<int>(nullable: false),
                    VrstaPoda = table.Column<string>(maxLength: 20, nullable: false),
                    ProjekatZaGradjevinskuDozvoluId = table.Column<int>(nullable: false),
                    VrstaPovrsineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Povrsina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Povrsina_ProjekatZaGradjevinskuDozvolu_ProjekatZaGradjevinskuDozvoluId",
                        column: x => x.ProjekatZaGradjevinskuDozvoluId,
                        principalTable: "ProjekatZaGradjevinskuDozvolu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Povrsina_VrstaPovrsine_VrstaPovrsineId",
                        column: x => x.VrstaPovrsineId,
                        principalTable: "VrstaPovrsine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IdejnoResenje_GlavniProjektantId",
                table: "IdejnoResenje",
                column: "GlavniProjektantId");

            migrationBuilder.CreateIndex(
                name: "IX_IdejnoResenje_LokacijskaDozvolaId",
                table: "IdejnoResenje",
                column: "LokacijskaDozvolaId");

            migrationBuilder.CreateIndex(
                name: "IX_IdejnoResenje_ObjekatId",
                table: "IdejnoResenje",
                column: "ObjekatId");

            migrationBuilder.CreateIndex(
                name: "IX_LokacijskaDozvola_InformacijeOLokacijiId",
                table: "LokacijskaDozvola",
                column: "InformacijeOLokacijiId");

            migrationBuilder.CreateIndex(
                name: "IX_Povrsina_ProjekatZaGradjevinskuDozvoluId",
                table: "Povrsina",
                column: "ProjekatZaGradjevinskuDozvoluId");

            migrationBuilder.CreateIndex(
                name: "IX_Povrsina_VrstaPovrsineId",
                table: "Povrsina",
                column: "VrstaPovrsineId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjekatZaGradjevinskuDozvolu_IdejnoResenjeId",
                table: "ProjekatZaGradjevinskuDozvolu",
                column: "IdejnoResenjeId");

            migrationBuilder.CreateIndex(
                name: "IX_Prostorija_VrstaPovrsineId",
                table: "Prostorija",
                column: "VrstaPovrsineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Povrsina");

            migrationBuilder.DropTable(
                name: "Prostorija");

            migrationBuilder.DropTable(
                name: "ProjekatZaGradjevinskuDozvolu");

            migrationBuilder.DropTable(
                name: "VrstaPovrsine");

            migrationBuilder.DropTable(
                name: "IdejnoResenje");

            migrationBuilder.DropTable(
                name: "GlavniProjektant");

            migrationBuilder.DropTable(
                name: "LokacijskaDozvola");

            migrationBuilder.DropTable(
                name: "Objekat");

            migrationBuilder.DropTable(
                name: "InformacijeOLokaciji");
        }
    }
}
