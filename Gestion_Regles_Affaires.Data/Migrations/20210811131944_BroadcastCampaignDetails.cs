using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_Regles_Affaires.Data.Migrations
{
    public partial class BroadcastCampaignDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsConfirmed",
                table: "BroadcastCampaignDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsConfirmed",
                table: "BroadcastCampaignDetails");
        }
    }
}
