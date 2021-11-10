using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_Regles_Affaires.Data.Migrations
{
    public partial class ChangeParameterValueColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "BusinessRulesParameterValue",
                newName: "Key");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 1,
                column: "Key",
                value: "class-1");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 2,
                column: "Key",
                value: "class-2");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 3,
                column: "Key",
                value: "class-3");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 4,
                column: "Key",
                value: "class-4");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 5,
                column: "Key",
                value: "mod-hor-1");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 6,
                column: "Key",
                value: "mod-hor-2");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 7,
                column: "Key",
                value: "mod-hor-3");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 8,
                column: "Key",
                value: "mod-hor-4");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 9,
                column: "Key",
                value: "group-contact-1");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 10,
                column: "Key",
                value: "group-contact-2");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 11,
                column: "Key",
                value: "group-contact-3");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 12,
                column: "Key",
                value: "group-contact-4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Key",
                table: "BusinessRulesParameterValue",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Classification 1");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Classification 2");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Classification 3");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Classification 4");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "modèle horaire d'appel 1");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "modèle horaire d'appel 2");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "modèle horaire d'appel 3");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "modèle horaire d'appel 4");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "groupe de contact 1");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "groupe de contact 2");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "groupe de contact 3");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "groupe de contact 4");
        }
    }
}
