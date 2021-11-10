using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_Regles_Affaires.Data.Migrations
{
    public partial class SeedBusinessRulesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BusinessRules",
                columns: new[] { "BusinessRulesId", "HasParameter", "IsRequired", "ParameterType", "ParameterValue", "Title" },
                values: new object[,]
                {
                    { 1, false, true, "input", "", "Nombre de personnes" },
                    { 25, false, false, "checkbox", "", "Poursuivre avec la même liste" },
                    { 24, false, false, "checkbox", "", "Division de l'appel" },
                    { 23, false, false, "input", "", "Tentative à tous les contacts" },
                    { 22, false, false, "input", "", "Tentative des non joints" },
                    { 21, false, false, "text area", "", "Appel différent sur les heures de travail" },
                    { 20, false, false, "checkbox", "", "Appel seulement sur les heures de travail" },
                    { 19, false, false, "checkbox", "", "Employé en usine en premier" },
                    { 18, false, false, "input", "", "Temps après le poste" },
                    { 17, false, false, "input", "", "Temps avant le poste" },
                    { 16, false, false, "input", "", "Maximum de temps travaillé" },
                    { 15, false, false, "input", "", "Temps supplémentaire maximum" },
                    { 26, false, false, "input", "", "Délais entre les appels" },
                    { 14, false, true, "input", "", "Employés Temps plein" },
                    { 12, false, true, "input", "", "Appeler en ordre de temps supplémentaire exécuté" },
                    { 11, false, false, "checkbox", "", "Ne pas recontacter les refusés pour le même jour" },
                    { 10, true, false, "dropdown", "groupe de contact 1;groupe de contact 2;groupe de contact 3;groupe de contact 4", "Priorisé un groupe de contacts" },
                    { 9, false, false, "calendar", "", "Heure total maximum de travail" },
                    { 8, false, false, "calendar", "", "Minimum sur le total heure pour les horaires normales" },
                    { 7, true, false, "dropdown", "modèle horaire d'appel 1;modèle horaire d'appel 2;modèle horaire d'appel 3;modèle horaire d'appel 4", "Modèle horaire d'appel" },
                    { 6, true, true, "checkbox", "Classification 1;Classification 2;Classification 3;Classification 4", "Classification de l'employé" },
                    { 5, false, true, "input", "", "Nombre d'heures de pause" },
                    { 4, false, true, "calendar", "", "Nombre d'heure au lieu de l'heure de fin" },
                    { 3, false, true, "calendar", "", "Date de fin du quart de travail proposée" },
                    { 2, false, true, "calendar", "", "Date de début du quart de travail proposée" },
                    { 13, false, true, "input", "", "Ancienneté" },
                    { 27, false, true, "input", "", "Priorité de la diffusion" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 27);
        }
    }
}
