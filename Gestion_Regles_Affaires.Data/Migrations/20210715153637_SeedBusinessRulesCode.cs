using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_Regles_Affaires.Data.Migrations
{
    public partial class SeedBusinessRulesCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 6,
                column: "Code",
                value: "EmployeeClassification");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 7,
                column: "Code",
                value: "CallScheduleModel");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 8,
                column: "Code",
                value: "MinimumHoursOutOfTotalHours");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 9,
                column: "Code",
                value: "WorkingMaximumTotalHours");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 10,
                column: "Code",
                value: "ContactGroupsPriorities");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 11,
                column: "Code",
                value: "DoNotRecontactBlackListedMembersForTheSameDay");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 12,
                column: "Code",
                value: "CallBasedOnOvertime");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 13,
                column: "Code",
                value: "CallBasedOnSeniority");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 14,
                column: "Code",
                value: "CallBasedOnFullTimeEmployee");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 15,
                column: "Code",
                value: "MaximumOvertime");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 16,
                column: "Code",
                value: "MaximumWorkingHours");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 17,
                column: "Code",
                value: "TimeBeforeShift");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 18,
                column: "Code",
                value: "TimeAfterShift");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 19,
                column: "Code",
                value: "CompanyEmployeeFirst");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 20,
                column: "Code",
                value: "CallDuringWorkingHoursOnly");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 21,
                column: "Code",
                value: "ManualContactEmails");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 22,
                column: "Code",
                value: "AttemptNumberOfNotJoined");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 23,
                column: "Code",
                value: "AttemptNumberOfAllContacts");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 24,
                column: "Code",
                value: "SplitTheCall");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 25,
                column: "Code",
                value: "ContinueWithTheSameList");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 26,
                column: "Code",
                value: "TimeBetweenCalls");

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 27,
                column: "Code",
                value: "BroadcastPriority");

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 8,
                column: "BusinessRulesId",
                value: 7);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 6,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 7,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 8,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 9,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 10,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 11,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 12,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 13,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 14,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 15,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 16,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 17,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 18,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 19,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 20,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 21,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 22,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 23,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 24,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 25,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 26,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRules",
                keyColumn: "BusinessRulesId",
                keyValue: 27,
                column: "Code",
                value: null);

            migrationBuilder.UpdateData(
                table: "BusinessRulesParameterValue",
                keyColumn: "Id",
                keyValue: 8,
                column: "BusinessRulesId",
                value: 8);
        }
    }
}
