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
                    Naziv = table.Column<string>(nullable: true),
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
                    Naziv = table.Column<string>(nullable: true),
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
                    IdejnoResenjeId = table.Column<int>(nullable: false),
                    StatusDokumenta = table.Column<int>(nullable: false)
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
                    VrstaPovrsineId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
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

            migrationBuilder.InsertData(
                table: "GlavniProjektant",
                columns: new[] { "Id", "BrojLicence", "ImePrezime", "Zvanje" },
                values: new object[,]
                {
                    { 1, 134L, "ImePrezime 1", "Zvanje 1" },
                    { 2, 54L, "ImePrezime 2", "Zvanje 2" },
                    { 3, 5343L, "ImePrezime 3", "Zvanje 3" },
                    { 4, 28L, "ImePrezime 4", "Zvanje 4" },
                    { 5, 335L, "ImePrezime 5", "Zvanje 5" }
                });

            migrationBuilder.InsertData(
                table: "InformacijeOLokaciji",
                columns: new[] { "Id", "DatumIzdavanja", "NamenaZemljista", "Naziv", "Zona" },
                values: new object[,]
                {
                    { 4, new DateTime(2020, 6, 9, 13, 53, 3, 732, DateTimeKind.Utc).AddTicks(9503), "Namena 4", "Naziv 4", "Zona 4" },
                    { 3, new DateTime(2020, 6, 9, 13, 53, 3, 732, DateTimeKind.Utc).AddTicks(9500), "Namena 3", "Naziv 3", "Zona 3" },
                    { 5, new DateTime(2020, 6, 9, 13, 53, 3, 732, DateTimeKind.Utc).AddTicks(9505), "Namena 5", "Naziv 5", "Zona 5" },
                    { 1, new DateTime(2020, 6, 9, 13, 53, 3, 732, DateTimeKind.Utc).AddTicks(8031), "Namena 1", "Naziv 1", "Zona 1" },
                    { 2, new DateTime(2020, 6, 9, 13, 53, 3, 732, DateTimeKind.Utc).AddTicks(9471), "Namena 2", "Naziv 2", "Zona 2" }
                });

            migrationBuilder.InsertData(
                table: "Objekat",
                columns: new[] { "Id", "BrojParcele", "Naziv" },
                values: new object[,]
                {
                    { 1, 6934L, "Naziv 1" },
                    { 2, 48643L, "Naziv 2" },
                    { 3, 4843L, "Naziv 3" },
                    { 4, 3458L, "Naziv 4" },
                    { 5, 34343L, "Naziv 5" }
                });

            migrationBuilder.InsertData(
                table: "VrstaPovrsine",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 4, "Naziv 4" },
                    { 1, "Naziv 1" },
                    { 2, "Naziv 2" },
                    { 3, "Naziv 3" },
                    { 5, "Naziv 5" }
                });

            migrationBuilder.InsertData(
                table: "LokacijskaDozvola",
                columns: new[] { "Id", "BrojParcele", "DatumIzdavanja", "InformacijeOLokacijiId", "NazivObjekta", "PovrsinaParcele" },
                values: new object[,]
                {
                    { 4, 3458L, new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(5767), 1, "Naziv 4", 34534L },
                    { 2, 48643L, new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(5726), 2, "Naziv 2", 412L },
                    { 1, 6934L, new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(4484), 3, "Naziv 1", 324L },
                    { 5, 34343L, new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(5768), 4, "Naziv 5", 3483L },
                    { 3, 4843L, new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(5764), 5, "Naziv 3", 3453L }
                });

            migrationBuilder.InsertData(
                table: "Prostorija",
                columns: new[] { "Id", "Naziv", "VrstaPovrsineId" },
                values: new object[,]
                {
                    { 1, "Naziv 1", 1 },
                    { 4, "Naziv 4", 2 },
                    { 3, "Naziv 3", 3 },
                    { 5, "Naziv 5", 4 },
                    { 2, "Naziv 2", 5 }
                });

            migrationBuilder.InsertData(
                table: "IdejnoResenje",
                columns: new[] { "Id", "DatumIzrade", "GlavniProjektantId", "LokacijskaDozvolaId", "Naziv", "ObjekatId" },
                values: new object[,]
                {
                    { 5, new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(9851), 3, 4, "Naziv 5", 5 },
                    { 4, new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(9783), 4, 2, "Naziv 4", 2 },
                    { 1, new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(8247), 2, 1, "Naziv 1", 4 },
                    { 2, new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(9752), 5, 5, "Naziv 2", 1 },
                    { 3, new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(9781), 1, 3, "Naziv 3", 3 }
                });

            migrationBuilder.InsertData(
                table: "ProjekatZaGradjevinskuDozvolu",
                columns: new[] { "Id", "DatumIzrade", "IdejnoResenjeId", "Naziv", "StatusDokumenta" },
                values: new object[,]
                {
                    { 4, new DateTime(2020, 6, 9, 13, 53, 3, 735, DateTimeKind.Utc).AddTicks(3498), 5, "Naziv 4", 0 },
                    { 1, new DateTime(2020, 6, 9, 13, 53, 3, 735, DateTimeKind.Utc).AddTicks(2144), 4, "Naziv 1", 0 },
                    { 2, new DateTime(2020, 6, 9, 13, 53, 3, 735, DateTimeKind.Utc).AddTicks(3462), 1, "Naziv 2", 0 },
                    { 3, new DateTime(2020, 6, 9, 13, 53, 3, 735, DateTimeKind.Utc).AddTicks(3496), 2, "Naziv 3", 0 },
                    { 5, new DateTime(2020, 6, 9, 13, 53, 3, 735, DateTimeKind.Utc).AddTicks(3500), 3, "Naziv 5", 0 }
                });

            migrationBuilder.InsertData(
                table: "Povrsina",
                columns: new[] { "Id", "Oznaka", "ProjekatZaGradjevinskuDozvoluId", "Status", "VrstaPoda", "VrstaPovrsineId" },
                values: new object[,]
                {
                    { 2, 75, 4, 0, "Vrsta 2", 2 },
                    { 1, 123, 1, 0, "Vrsta 1", 4 },
                    { 3, 678, 3, 0, "Vrsta 3", 3 },
                    { 5, 3857, 3, 0, "Vrsta 5", 5 },
                    { 4, 74, 5, 0, "Vrsta 4", 1 }
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
