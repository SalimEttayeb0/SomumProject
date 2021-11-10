using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_Regles_Affaires.Data.Migrations
{
    public partial class UpdateModelTableFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "ModelBusinessRules");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Modeles",
                newName: "ModelName");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Modeles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Modeles");

            migrationBuilder.RenameColumn(
                name: "ModelName",
                table: "Modeles",
                newName: "Description");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "ModelBusinessRules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
