using Microsoft.EntityFrameworkCore.Migrations;

namespace Aiko.GestEquipamento.Infra.Data.Migrations
{
    public partial class Db_first15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "equipment_model_pkey",
                schema: "operation",
                table: "equipment");

            migrationBuilder.AddForeignKey(
                name: "FK_equipment_equipment_model_equipment_model_id",
                schema: "operation",
                table: "equipment",
                column: "equipment_model_id",
                principalSchema: "operation",
                principalTable: "equipment_model",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_equipment_equipment_model_equipment_model_id",
                schema: "operation",
                table: "equipment");

            migrationBuilder.AddForeignKey(
                name: "equipment_model_pkey",
                schema: "operation",
                table: "equipment",
                column: "equipment_model_id",
                principalSchema: "operation",
                principalTable: "equipment_model",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
