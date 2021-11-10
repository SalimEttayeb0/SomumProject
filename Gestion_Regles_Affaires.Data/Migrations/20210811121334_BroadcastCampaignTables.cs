using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_Regles_Affaires.Data.Migrations
{
    public partial class BroadcastCampaignTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModelBusinessRules_Modeles_ModelId",
                table: "ModelBusinessRules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modeles",
                table: "Modeles");

            migrationBuilder.RenameTable(
                name: "Modeles",
                newName: "Models");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "ModelId");

            migrationBuilder.CreateTable(
                name: "BroadcastCampaigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BroadcastCampaigns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BroadcastCampaignDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfferResponse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BroadcastCampaignId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BroadcastCampaignDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BroadcastCampaignDetails_BroadcastCampaigns_BroadcastCampaignId",
                        column: x => x.BroadcastCampaignId,
                        principalTable: "BroadcastCampaigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BroadcastCampaignDetails_BroadcastCampaignId",
                table: "BroadcastCampaignDetails",
                column: "BroadcastCampaignId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModelBusinessRules_Models_ModelId",
                table: "ModelBusinessRules",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "ModelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModelBusinessRules_Models_ModelId",
                table: "ModelBusinessRules");

            migrationBuilder.DropTable(
                name: "BroadcastCampaignDetails");

            migrationBuilder.DropTable(
                name: "BroadcastCampaigns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.RenameTable(
                name: "Models",
                newName: "Modeles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modeles",
                table: "Modeles",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModelBusinessRules_Modeles_ModelId",
                table: "ModelBusinessRules",
                column: "ModelId",
                principalTable: "Modeles",
                principalColumn: "ModelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
