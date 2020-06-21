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
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
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
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Dimenzije = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Karakteristike = table.Column<string>(maxLength: 255, nullable: false)
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
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    OpstiPodaci = table.Column<string>(maxLength: 255, nullable: false),
                    LokacijskiUslovi = table.Column<string>(maxLength: 255, nullable: false),
                    BrojParcele = table.Column<long>(nullable: false),
                    PovrsinaParcele = table.Column<long>(nullable: false),
                    DatumIzdavanja = table.Column<DateTime>(nullable: false),
                    InformacijeOLokacijiId = table.Column<int>(nullable: false),
                    NazivIdejnogResenja = table.Column<string>(nullable: true)
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
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
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
                    NazivIdejnogResenja = table.Column<string>(nullable: true),
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
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    VrstaPoda = table.Column<string>(maxLength: 20, nullable: false),
                    ProjekatZaGradjevinskuDozvoluId = table.Column<int>(nullable: false),
                    VrstaPovrsineId = table.Column<int>(nullable: false),
                    ProstorijaNaziv = table.Column<string>(nullable: true),
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
                    { 10, new DateTime(2020, 6, 20, 12, 9, 5, 293, DateTimeKind.Utc).AddTicks(7921), "Namena 10", "Informacije o lokaciji 10", "Zona 10" },
                    { 9, new DateTime(2020, 6, 20, 12, 9, 5, 293, DateTimeKind.Utc).AddTicks(7918), "Namena 9", "Informacije o lokaciji 9", "Zona 9" },
                    { 7, new DateTime(2020, 6, 20, 12, 9, 5, 293, DateTimeKind.Utc).AddTicks(7912), "Namena 7", "Informacije o lokaciji 7", "Zona 7" },
                    { 6, new DateTime(2020, 6, 20, 12, 9, 5, 293, DateTimeKind.Utc).AddTicks(7909), "Namena 6", "Informacije o lokaciji 6", "Zona 6" },
                    { 8, new DateTime(2020, 6, 20, 12, 9, 5, 293, DateTimeKind.Utc).AddTicks(7914), "Namena 8", "Informacije o lokaciji 8", "Zona 8" },
                    { 4, new DateTime(2020, 6, 20, 12, 9, 5, 293, DateTimeKind.Utc).AddTicks(7903), "Namena 4", "Informacije o lokaciji 4", "Zona 4" },
                    { 3, new DateTime(2020, 6, 20, 12, 9, 5, 293, DateTimeKind.Utc).AddTicks(7899), "Namena 3", "Informacije o lokaciji 3", "Zona 3" },
                    { 2, new DateTime(2020, 6, 20, 12, 9, 5, 293, DateTimeKind.Utc).AddTicks(7855), "Namena 2", "Informacije o lokaciji 2", "Zona 2" },
                    { 1, new DateTime(2020, 6, 20, 12, 9, 5, 293, DateTimeKind.Utc).AddTicks(6124), "Namena 1", "Informacije o lokaciji 1", "Zona 1" },
                    { 5, new DateTime(2020, 6, 20, 12, 9, 5, 293, DateTimeKind.Utc).AddTicks(7906), "Namena 5", "Informacije o lokaciji 5", "Zona 5" }
                });

            migrationBuilder.InsertData(
                table: "Objekat",
                columns: new[] { "Id", "Dimenzije", "Karakteristike", "Naziv" },
                values: new object[,]
                {
                    { 1, 323m, "Karakteristika 1", "Objekat 1" },
                    { 2, 432m, "Karakteristika 2", "Objekat 2" },
                    { 3, 545m, "Karakteristika 3", "Objekat 3" },
                    { 4, 216m, "Karakteristika 4", "Objekat 4" },
                    { 5, 786m, "Karakteristika 5", "Objekat 5" }
                });

            migrationBuilder.InsertData(
                table: "VrstaPovrsine",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 4, "Vrsta povrsine 4" },
                    { 1, "Vrsta povrsine 1" },
                    { 2, "Vrsta povrsine 2" },
                    { 3, "Vrsta povrsine 3" },
                    { 5, "Vrsta povrsine 5" }
                });

            migrationBuilder.InsertData(
                table: "LokacijskaDozvola",
                columns: new[] { "Id", "BrojParcele", "DatumIzdavanja", "InformacijeOLokacijiId", "LokacijskiUslovi", "Naziv", "NazivIdejnogResenja", "OpstiPodaci", "PovrsinaParcele" },
                values: new object[,]
                {
                    { 4, 3458L, new DateTime(2020, 6, 20, 12, 9, 5, 296, DateTimeKind.Utc).AddTicks(719), 1, "Lokacijski uslovi 4", "Lokacijska dozvola 4", null, "Opsti podaci 4", 34534L },
                    { 2, 48643L, new DateTime(2020, 6, 20, 12, 9, 5, 296, DateTimeKind.Utc).AddTicks(686), 2, "Lokacijski uslovi 2", "Lokacijska dozvola 2", null, "Opsti podaci 2", 412L },
                    { 1, 6934L, new DateTime(2020, 6, 20, 12, 9, 5, 295, DateTimeKind.Utc).AddTicks(9417), 3, "Lokacijski uslovi 1", "Lokacijska dozvola 1", null, "Opsti podaci 1", 324L },
                    { 5, 34343L, new DateTime(2020, 6, 20, 12, 9, 5, 296, DateTimeKind.Utc).AddTicks(722), 4, "Lokacijski uslovi 5", "Lokacijska dozvola 5", null, "Opsti podaci 5", 3483L },
                    { 3, 4843L, new DateTime(2020, 6, 20, 12, 9, 5, 296, DateTimeKind.Utc).AddTicks(714), 5, "Lokacijski uslovi 3", "Lokacijska dozvola 3", null, "Opsti podaci 3", 3453L }
                });

            migrationBuilder.InsertData(
                table: "Prostorija",
                columns: new[] { "Id", "Naziv", "VrstaPovrsineId" },
                values: new object[,]
                {
                    { 1, "Prostorija 1", 1 },
                    { 4, "Prostorija 4", 2 },
                    { 3, "Prostorija 3", 3 },
                    { 5, "Prostorija 5", 4 },
                    { 2, "Prostorija 2", 5 }
                });

            migrationBuilder.InsertData(
                table: "IdejnoResenje",
                columns: new[] { "Id", "DatumIzrade", "GlavniProjektantId", "LokacijskaDozvolaId", "Naziv", "ObjekatId" },
                values: new object[,]
                {
                    { 5, new DateTime(2020, 6, 20, 12, 9, 5, 296, DateTimeKind.Utc).AddTicks(6756), 3, 4, "Idejno resenje 5", 5 },
                    { 8, new DateTime(2020, 6, 20, 12, 9, 5, 296, DateTimeKind.Utc).AddTicks(6765), 2, 4, "Idejno resenje 8", 4 },
                    { 9, new DateTime(2020, 6, 20, 12, 9, 5, 296, DateTimeKind.Utc).AddTicks(6768), 4, 4, "Idejno resenje 9", 4 },
                    { 4, new DateTime(2020, 6, 20, 12, 9, 5, 296, DateTimeKind.Utc).AddTicks(6751), 4, 2, "Idejno resenje 4", 2 },
                    { 7, new DateTime(2020, 6, 20, 12, 9, 5, 296, DateTimeKind.Utc).AddTicks(6762), 1, 2, "Idejno resenje 7", 3 },
                    { 1, new DateTime(2020, 6, 20, 12, 9, 5, 296, DateTimeKind.Utc).AddTicks(4293), 2, 1, "Idejno resenje 1", 4 },
                    { 6, new DateTime(2020, 6, 20, 12, 9, 5, 296, DateTimeKind.Utc).AddTicks(6759), 2, 1, "Idejno resenje 6", 3 },
                    { 2, new DateTime(2020, 6, 20, 12, 9, 5, 296, DateTimeKind.Utc).AddTicks(6680), 5, 5, "Idejno resenje 2", 1 },
                    { 10, new DateTime(2020, 6, 20, 12, 9, 5, 296, DateTimeKind.Utc).AddTicks(6770), 4, 5, "Idejno resenje 10", 5 },
                    { 3, new DateTime(2020, 6, 20, 12, 9, 5, 296, DateTimeKind.Utc).AddTicks(6747), 1, 3, "Idejno resenje 3", 3 }
                });

            migrationBuilder.InsertData(
                table: "ProjekatZaGradjevinskuDozvolu",
                columns: new[] { "Id", "DatumIzrade", "IdejnoResenjeId", "Naziv", "NazivIdejnogResenja", "StatusDokumenta" },
                values: new object[,]
                {
                    { 5, new DateTime(2020, 6, 20, 12, 9, 5, 297, DateTimeKind.Utc).AddTicks(6279), 5, "Projekat 5", null, 1 },
                    { 9, new DateTime(2020, 6, 20, 12, 9, 5, 297, DateTimeKind.Utc).AddTicks(6292), 8, "Projekat 9", null, 1 },
                    { 3, new DateTime(2020, 6, 20, 12, 9, 5, 297, DateTimeKind.Utc).AddTicks(6274), 9, "Projekat 3", null, 1 },
                    { 8, new DateTime(2020, 6, 20, 12, 9, 5, 297, DateTimeKind.Utc).AddTicks(6289), 4, "Projekat 8", null, 1 },
                    { 2, new DateTime(2020, 6, 20, 12, 9, 5, 297, DateTimeKind.Utc).AddTicks(6232), 7, "Projekat 2", null, 1 },
                    { 4, new DateTime(2020, 6, 20, 12, 9, 5, 297, DateTimeKind.Utc).AddTicks(6277), 1, "Projekat 4", null, 1 },
                    { 10, new DateTime(2020, 6, 20, 12, 9, 5, 297, DateTimeKind.Utc).AddTicks(6294), 6, "Projekat 10", null, 1 },
                    { 1, new DateTime(2020, 6, 20, 12, 9, 5, 297, DateTimeKind.Utc).AddTicks(4550), 2, "Projekat 1", null, 1 },
                    { 7, new DateTime(2020, 6, 20, 12, 9, 5, 297, DateTimeKind.Utc).AddTicks(6285), 10, "Projekat 7", null, 1 },
                    { 6, new DateTime(2020, 6, 20, 12, 9, 5, 297, DateTimeKind.Utc).AddTicks(6282), 3, "Projekat 6", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Povrsina",
                columns: new[] { "Id", "Naziv", "Oznaka", "ProjekatZaGradjevinskuDozvoluId", "ProstorijaNaziv", "Status", "VrstaPoda", "VrstaPovrsineId" },
                values: new object[,]
                {
                    { 4, "Povrsina 4", 7434, 5, null, 0, "Vrsta 4", 1 },
                    { 24, "Povrsina 24", 54, 10, null, 0, "Vrsta 24", 1 },
                    { 34, "Povrsina 44", 65342, 10, null, 0, "Vrsta 34", 1 },
                    { 1, "Povrsina 1", 1423, 1, null, 0, "Vrsta 1", 4 },
                    { 9, "Povrsina 9", 113, 1, null, 0, "Vrsta 9", 2 },
                    { 10, "Povrsina 10", 11, 1, null, 0, "Vrsta 10", 3 },
                    { 11, "Povrsina 11", 432, 1, null, 0, "Vrsta 11", 4 },
                    { 19, "Povrsina 19", 111, 1, null, 0, "Vrsta 19", 2 },
                    { 12, "Povrsina 12", 554, 4, null, 0, "Vrsta 12", 2 },
                    { 20, "Povrsina 20", 978, 1, null, 0, "Vrsta 20", 3 },
                    { 28, "Povrsina 28", 541, 7, null, 0, "Vrsta 28", 1 },
                    { 37, "Povrsina 47", 203, 7, null, 0, "Vrsta 37", 1 },
                    { 38, "Povrsina 48", 110, 7, null, 0, "Vrsta 38", 1 },
                    { 21, "Povrsina 21", 65, 6, null, 0, "Vrsta 21", 4 },
                    { 29, "Povrsina 29", 313, 6, null, 0, "Vrsta 29", 2 },
                    { 30, "Povrsina 30", 467, 6, null, 0, "Vrsta 30", 3 },
                    { 31, "Povrsina 41", 984, 6, null, 0, "Vrsta 31", 4 },
                    { 27, "Povrsina 27", 123, 7, null, 0, "Vrsta 27", 1 },
                    { 2, "Povrsina 2", 755, 4, null, 0, "Vrsta 2", 2 },
                    { 18, "Povrsina 18", 467, 2, null, 0, "Vrsta 18", 1 },
                    { 17, "Povrsina 17", 231, 2, null, 0, "Vrsta 17", 1 },
                    { 14, "Povrsina 14", 456, 5, null, 0, "Vrsta 14", 1 },
                    { 22, "Povrsina 22", 234, 9, null, 0, "Vrsta 22", 2 },
                    { 32, "Povrsina 42", 32, 9, null, 0, "Vrsta 32", 2 },
                    { 3, "Povrsina 3", 678, 3, null, 0, "Vrsta 3", 3 },
                    { 5, "Povrsina 5", 231, 3, null, 0, "Vrsta 5", 5 },
                    { 6, "Povrsina 6", 3121, 3, null, 0, "Vrsta 6", 5 },
                    { 13, "Povrsina 13", 32, 3, null, 0, "Vrsta 13", 3 },
                    { 15, "Povrsina 15", 231, 3, null, 0, "Vrsta 15", 5 },
                    { 16, "Povrsina 16", 411, 3, null, 0, "Vrsta 16", 5 },
                    { 23, "Povrsina 23", 543, 8, null, 0, "Vrsta 23", 3 },
                    { 25, "Povrsina 25", 7865, 8, null, 0, "Vrsta 25", 5 },
                    { 26, "Povrsina 26", 465, 8, null, 0, "Vrsta 26", 5 },
                    { 33, "Povrsina 43", 7764, 8, null, 0, "Vrsta 33", 3 },
                    { 35, "Povrsina 45", 3219, 8, null, 0, "Vrsta 35", 5 },
                    { 36, "Povrsina 46", 890, 8, null, 0, "Vrsta 36", 5 },
                    { 7, "Povrsina 7", 542, 2, null, 0, "Vrsta 7", 1 },
                    { 8, "Povrsina 8", 64, 2, null, 0, "Vrsta 8", 1 },
                    { 39, "Povrsina 49", 903, 6, null, 0, "Vrsta 39", 2 },
                    { 40, "Povrsina 50", 314, 6, null, 0, "Vrsta 40", 3 }
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
