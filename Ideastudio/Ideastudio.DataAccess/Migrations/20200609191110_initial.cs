using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ideastudio.DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IdejnoResenje",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "IdejnoResenje",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "IdejnoResenje",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "IdejnoResenje",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "IdejnoResenje",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "InformacijeOLokaciji",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 732, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "InformacijeOLokaciji",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 732, DateTimeKind.Utc).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "InformacijeOLokaciji",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 732, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "InformacijeOLokaciji",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 732, DateTimeKind.Utc).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "InformacijeOLokaciji",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 732, DateTimeKind.Utc).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "LokacijskaDozvola",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "LokacijskaDozvola",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "LokacijskaDozvola",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "LokacijskaDozvola",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "LokacijskaDozvola",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumIzdavanja",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 734, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "ProjekatZaGradjevinskuDozvolu",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 735, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "ProjekatZaGradjevinskuDozvolu",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 735, DateTimeKind.Utc).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "ProjekatZaGradjevinskuDozvolu",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 735, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "ProjekatZaGradjevinskuDozvolu",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 735, DateTimeKind.Utc).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "ProjekatZaGradjevinskuDozvolu",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatumIzrade",
                value: new DateTime(2020, 6, 9, 13, 53, 3, 735, DateTimeKind.Utc).AddTicks(3500));
        }
    }
}
