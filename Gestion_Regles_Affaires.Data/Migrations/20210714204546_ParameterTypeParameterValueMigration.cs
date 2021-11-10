using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_Regles_Affaires.Data.Migrations
{
    public partial class ParameterTypeParameterValueMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParameterType",
                table: "BusinessRules");

            migrationBuilder.DropColumn(
                name: "ParameterValue",
                table: "BusinessRules");

            migrationBuilder.AddColumn<int>(
                name: "ParameterTypeId",
                table: "BusinessRules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BusinessRulesParameterValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessRulesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessRulesParameterValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessRulesParameterValue_BusinessRules_BusinessRulesId",
                        column: x => x.BusinessRulesId,
                        principalTable: "BusinessRules",
                        principalColumn: "BusinessRulesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParameterTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BusinessRulesParameterValue",
                columns: new[] { "Id", "BusinessRulesId", "Name" },
                values: new object[,]
                {
                    { 1, 6, "Classification 1" },
                    { 12, 10, "groupe de contact 4" },
                    { 11, 10, "groupe de contact 3" },
                    { 10, 10, "groupe de contact 2" },
                    { 8, 6, "modèle horaire d'appel 4" },
                    { 7, 6, "modèle horaire d'appel 3" },
                    { 9, 10, "groupe de contact 1" },
                    { 5, 7, "modèle horaire d'appel 1" },
                    { 4, 6, "Classification 4" },
                    { 3, 6, "Classification 3" },
                    { 2, 6, "Classification 2" },
                    { 6, 6, "modèle horaire d'appel 2" }
                });

            migrationBuilder.InsertData(
                table: "ParameterTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Number" },
                    { 1, "checkbox" },
                    { 2, "dropdown" },
                    { 3, "DateTime" },
                    { 5, "String" }
                });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 1,
                column: "ParameterTypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 2,
                column: "ParameterTypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 3,
                column: "ParameterTypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 4,
                column: "ParameterTypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 5,
                column: "ParameterTypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 6,
                column: "ParameterTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 7,
                column: "ParameterTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 8,
                column: "ParameterTypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 9,
                column: "ParameterTypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 10,
                column: "ParameterTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 11,
                column: "ParameterTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 12,
                column: "ParameterTypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 13,
                column: "ParameterTypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 14,
                column: "ParameterTypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 15,
                column: "ParameterTypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 16,
                column: "ParameterTypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 17,
                column: "ParameterTypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 18,
                column: "ParameterTypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 19,
                column: "ParameterTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 20,
                column: "ParameterTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 21,
                column: "ParameterTypeId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 22,
                column: "ParameterTypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 23,
                column: "ParameterTypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 24,
                column: "ParameterTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 25,
                column: "ParameterTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 26,
                column: "ParameterTypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 27,
                column: "ParameterTypeId",
                value: 4);

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRules_ParameterTypeId",
                table: "BusinessRules",
                column: "ParameterTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRulesParameterValue_BusinessRulesId",
                table: "BusinessRulesParameterValue",
                column: "BusinessRulesId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessRules_ParameterTypes_ParameterTypeId",
                table: "BusinessRules",
                column: "ParameterTypeId",
                principalTable: "ParameterTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessRules_ParameterTypes_ParameterTypeId",
                table: "BusinessRules");

            migrationBuilder.DropTable(
                name: "BusinessRulesParameterValue");

            migrationBuilder.DropTable(
                name: "ParameterTypes");

            migrationBuilder.DropIndex(
                name: "IX_BusinessRules_ParameterTypeId",
                table: "BusinessRules");

            migrationBuilder.DropColumn(
                name: "ParameterTypeId",
                table: "BusinessRules");

            migrationBuilder.AddColumn<string>(
                name: "ParameterType",
                table: "BusinessRules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParameterValue",
                table: "BusinessRules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 1,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "input", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 2,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "calendar", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 3,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "calendar", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 4,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "calendar", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 5,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "input", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 6,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "checkbox", "Classification 1;Classification 2;Classification 3;Classification 4" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 7,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "dropdown", "modèle horaire d'appel 1;modèle horaire d'appel 2;modèle horaire d'appel 3;modèle horaire d'appel 4" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 8,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "calendar", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 9,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "calendar", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 10,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "dropdown", "groupe de contact 1;groupe de contact 2;groupe de contact 3;groupe de contact 4" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 11,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "checkbox", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 12,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "input", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 13,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "input", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 14,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "input", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 15,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "input", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 16,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "input", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 17,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "input", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 18,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "input", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 19,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "checkbox", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 20,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "checkbox", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 21,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "text area", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 22,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "input", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 23,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "input", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 24,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "checkbox", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 25,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "checkbox", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 26,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "input", "" });

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 27,
                columns: new[] { "ParameterType", "ParameterValue" },
                values: new object[] { "input", "" });
        }
    }
}
