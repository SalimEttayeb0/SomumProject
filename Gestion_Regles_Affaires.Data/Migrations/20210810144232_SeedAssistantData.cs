using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_Regles_Affaires.Data.Migrations
{
    public partial class SeedAssistantData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BusinessRules",
                columns: new[] { "BusinessRulesId", "Code", "HasParameter", "IsRequired", "ParameterTypeId", "Title" },
                values: new object[] { 28, "ChooseAssistant", true, false, 2, "Choisir un assistant" });

            migrationBuilder.InsertData(
                table: "BusinessRulesParameterValue",
                columns: new[] { "Id", "BusinessRulesId", "Key" },
                values: new object[,]
                {
                    { 13, 28, "assistant-1" },
                    { 14, 28, "assistant-2" },
                    { 15, 28, "assistant-3" },
                    { 16, 28, "assistant-4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 28);
        }
    }
}
