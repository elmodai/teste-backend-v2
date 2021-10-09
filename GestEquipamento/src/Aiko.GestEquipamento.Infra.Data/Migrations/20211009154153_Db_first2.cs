using Microsoft.EntityFrameworkCore.Migrations;

namespace Aiko.GestEquipamento.Infra.Data.Migrations
{
    public partial class Db_first2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "lon",
                schema: "operation",
                table: "equipment_position_history",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<float>(
                name: "lat",
                schema: "operation",
                table: "equipment_position_history",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "lon",
                schema: "operation",
                table: "equipment_position_history",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "lat",
                schema: "operation",
                table: "equipment_position_history",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
