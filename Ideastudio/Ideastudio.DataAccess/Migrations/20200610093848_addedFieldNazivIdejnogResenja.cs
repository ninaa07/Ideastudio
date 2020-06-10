using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ideastudio.DataAccess.Migrations
{
    public partial class addedFieldNazivIdejnogResenja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NazivIdejnogResenja",
                table: "LokacijskaDozvola",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "IdejnoResenje",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 367, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "IdejnoResenje",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 367, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "IdejnoResenje",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 367, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "IdejnoResenje",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 367, DateTimeKind.Utc).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "IdejnoResenje",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 367, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "InformacijeOLokaciji",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 365, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "InformacijeOLokaciji",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 365, DateTimeKind.Utc).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "InformacijeOLokaciji",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 365, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "InformacijeOLokaciji",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 365, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "InformacijeOLokaciji",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 365, DateTimeKind.Utc).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "LokacijskaDozvola",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 366, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "LokacijskaDozvola",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 366, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "LokacijskaDozvola",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 366, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "LokacijskaDozvola",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 366, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "LokacijskaDozvola",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 366, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "ProjekatZaGradjevinskuDozvolu",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 367, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "ProjekatZaGradjevinskuDozvolu",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 367, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "ProjekatZaGradjevinskuDozvolu",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 367, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "ProjekatZaGradjevinskuDozvolu",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 367, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "ProjekatZaGradjevinskuDozvolu",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 10, 9, 38, 48, 367, DateTimeKind.Utc).AddTicks(4015));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NazivIdejnogResenja",
                table: "LokacijskaDozvola");

            migrationBuilder.UpdateData(
                table: "IdejnoResenje",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 650, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "IdejnoResenje",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 650, DateTimeKind.Utc).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "IdejnoResenje",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 650, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "IdejnoResenje",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 650, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "IdejnoResenje",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 650, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "InformacijeOLokaciji",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 647, DateTimeKind.Utc).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "InformacijeOLokaciji",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 647, DateTimeKind.Utc).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "InformacijeOLokaciji",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 647, DateTimeKind.Utc).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "InformacijeOLokaciji",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 647, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "InformacijeOLokaciji",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 647, DateTimeKind.Utc).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "LokacijskaDozvola",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 649, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "LokacijskaDozvola",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 649, DateTimeKind.Utc).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "LokacijskaDozvola",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 649, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "LokacijskaDozvola",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 650, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "LokacijskaDozvola",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 650, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "ProjekatZaGradjevinskuDozvolu",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 651, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "ProjekatZaGradjevinskuDozvolu",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 651, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "ProjekatZaGradjevinskuDozvolu",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 651, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "ProjekatZaGradjevinskuDozvolu",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 651, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "ProjekatZaGradjevinskuDozvolu",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 19, 11, 6, 651, DateTimeKind.Utc).AddTicks(4065));
        }
    }
}
