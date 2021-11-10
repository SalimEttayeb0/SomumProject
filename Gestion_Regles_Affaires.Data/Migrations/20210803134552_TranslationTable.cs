using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_Regles_Affaires.Data.Migrations
{
    public partial class TranslationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParameterValueTranslations");

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Culture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.CreateTable(
                name: "ParameterValueTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessRulesParameterValueID = table.Column<int>(type: "int", nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranslationName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterValueTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParameterValueTranslations_BusinessRulesParameterValue_BusinessRulesParameterValueID",
                        column: x => x.BusinessRulesParameterValueID,
                        principalTable: "BusinessRulesParameterValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ParameterValueTranslations",
                columns: new[] { "Id", "BusinessRulesParameterValueID", "LanguageCode", "TranslationName" },
                values: new object[,]
                {
                    { 1, 1, "fr", "Classification 1" },
                    { 22, 11, "en", "contact group 3" },
                    { 21, 11, "fr", "groupe de contact 3" },
                    { 20, 10, "en", "contact group 2" },
                    { 19, 10, "fr", "groupe de contact 2" },
                    { 18, 9, "en", "contact group 1" },
                    { 17, 9, "fr", "groupe de contact 1" },
                    { 16, 8, "en", "Call schedule model 4" },
                    { 15, 8, "fr", "modèle horaire d'appel 4" },
                    { 14, 7, "en", "Call schedule model 3" },
                    { 13, 7, "fr", "modèle horaire d'appel 3" },
                    { 12, 6, "en", "Call schedule model 2" },
                    { 11, 6, "fr", "modèle horaire d'appel 2" },
                    { 10, 5, "en", "Call schedule model 1" },
                    { 9, 5, "fr", "modèle horaire d'appel 1" },
                    { 8, 4, "en", "Classification 4" },
                    { 7, 4, "fr", "Classification 4" },
                    { 6, 3, "en", "Classification 3" },
                    { 5, 3, "fr", "Classification 3" },
                    { 4, 2, "en", "Classification 2" },
                    { 3, 2, "fr", "Classification 2" },
                    { 2, 1, "en", "Classification 1" },
                    { 23, 12, "fr", "groupe de contact 4" },
                    { 24, 12, "en", "contact group 4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParameterValueTranslations_BusinessRulesParameterValueID",
                table: "ParameterValueTranslations",
                column: "BusinessRulesParameterValueID");
        }
    }
}
