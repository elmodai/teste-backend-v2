using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aiko.GestEquipamento.Infra.Data.Migrations
{
    public partial class CodeFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "operation");

            migrationBuilder.CreateTable(
                name: "equipment_model",
                schema: "operation",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipment_model", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "equipment_state",
                schema: "operation",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true),
                    color = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipment_state", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "equipment",
                schema: "operation",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true),
                    equipment_model_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipment", x => x.id);
                    table.ForeignKey(
                        name: "FK_equipment_equipment_model_equipment_model_id",
                        column: x => x.equipment_model_id,
                        principalSchema: "operation",
                        principalTable: "equipment_model",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "equipment_model_state_hourly_earnings",
                schema: "operation",
                columns: table => new
                {
                    value = table.Column<double>(type: "double precision", nullable: false),
                    equipment_model_id = table.Column<Guid>(type: "uuid", nullable: false),
                    equipment_state_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_equipment_model_state_hourly_earnings_equipment_model_equip~",
                        column: x => x.equipment_model_id,
                        principalSchema: "operation",
                        principalTable: "equipment_model",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_equipment_model_state_hourly_earnings_equipment_state_equip~",
                        column: x => x.equipment_state_id,
                        principalSchema: "operation",
                        principalTable: "equipment_state",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "equipment_position_history",
                schema: "operation",
                columns: table => new
                {
                    lat = table.Column<double>(type: "double precision", nullable: false),
                    lon = table.Column<double>(type: "double precision", nullable: false),
                    equipment_id = table.Column<Guid>(type: "uuid", nullable: false),
                    date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_equipment_position_history_equipment_equipment_id",
                        column: x => x.equipment_id,
                        principalSchema: "operation",
                        principalTable: "equipment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "equipment_state_history",
                schema: "operation",
                columns: table => new
                {
                    equipment_state_id = table.Column<Guid>(type: "uuid", nullable: false),
                    equipment_id = table.Column<Guid>(type: "uuid", nullable: false),
                    date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_equipment_state_history_equipment_equipment_id",
                        column: x => x.equipment_id,
                        principalSchema: "operation",
                        principalTable: "equipment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_equipment_state_history_equipment_state_equipment_state_id",
                        column: x => x.equipment_state_id,
                        principalSchema: "operation",
                        principalTable: "equipment_state",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_equipment_equipment_model_id",
                schema: "operation",
                table: "equipment",
                column: "equipment_model_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipment_model_state_hourly_earnings_equipment_model_id",
                schema: "operation",
                table: "equipment_model_state_hourly_earnings",
                column: "equipment_model_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipment_model_state_hourly_earnings_equipment_state_id",
                schema: "operation",
                table: "equipment_model_state_hourly_earnings",
                column: "equipment_state_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipment_position_history_equipment_id",
                schema: "operation",
                table: "equipment_position_history",
                column: "equipment_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipment_state_history_equipment_id",
                schema: "operation",
                table: "equipment_state_history",
                column: "equipment_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipment_state_history_equipment_state_id",
                schema: "operation",
                table: "equipment_state_history",
                column: "equipment_state_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "equipment_model_state_hourly_earnings",
                schema: "operation");

            migrationBuilder.DropTable(
                name: "equipment_position_history",
                schema: "operation");

            migrationBuilder.DropTable(
                name: "equipment_state_history",
                schema: "operation");

            migrationBuilder.DropTable(
                name: "equipment",
                schema: "operation");

            migrationBuilder.DropTable(
                name: "equipment_state",
                schema: "operation");

            migrationBuilder.DropTable(
                name: "equipment_model",
                schema: "operation");
        }
    }
}
