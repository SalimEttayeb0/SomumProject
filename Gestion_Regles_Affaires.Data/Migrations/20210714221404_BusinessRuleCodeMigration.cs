using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_Regles_Affaires.Data.Migrations
{
    public partial class BusinessRuleCodeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "BusinessRules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 1,
                column: "Code",
                value: "PersonsNumber");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 2,
                column: "Code",
                value: "StartDate");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 3,
                column: "Code",
                value: "EndDate");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 4,
                column: "Code",
                value: "WorkHoursNumber");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 5,
                column: "Code",
                value: "PauseHoursNumber");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 6,
                column: "BusinessRulesId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 7,
                column: "BusinessRulesId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 8,
                column: "BusinessRulesId",
                value: 8);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "BusinessRules");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 6,
                column: "BusinessRulesId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 7,
                column: "BusinessRulesId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 8,
                column: "BusinessRulesId",
                value: 6);
        }
    }
}
