using Microsoft.EntityFrameworkCore.Migrations;

namespace Aiko.GestEquipamento.Infra.Data.Migrations
{
    public partial class Changing_double_to_float : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "value",
                schema: "operation",
                table: "equipment_model_state_hourly_earnings",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "value",
                schema: "operation",
                table: "equipment_model_state_hourly_earnings",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
