using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_Regles_Affaires.Data.Migrations
{
    public partial class ModelBusinessRulesTableConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Modeles",
                newName: "ModelId");

            migrationBuilder.CreateTable(
                name: "BusinessRules",
                columns: table => new
                {
                    BusinessRulesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasParameter = table.Column<bool>(type: "bit", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    ParameterType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParameterValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessRules", x => x.BusinessRulesId);
                });

            migrationBuilder.CreateTable(
                name: "ModelBusinessRules",
                columns: table => new
                {
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    BusinessRulesId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelBusinessRules", x => new { x.ModelId, x.BusinessRulesId });
                    table.ForeignKey(
                        name: "FK_ModelBusinessRules_BusinessRules_BusinessRulesId",
                        column: x => x.BusinessRulesId,
                        principalTable: "BusinessRules",
                        principalColumn: "BusinessRulesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModelBusinessRules_Modeles_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Modeles",
                        principalColumn: "ModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModelBusinessRules_BusinessRulesId",
                table: "ModelBusinessRules",
                column: "BusinessRulesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelBusinessRules");

            migrationBuilder.DropTable(
                name: "BusinessRules");

            migrationBuilder.RenameColumn(
                name: "ModelId",
                table: "Modeles",
                newName: "Id");
        }
    }
}
