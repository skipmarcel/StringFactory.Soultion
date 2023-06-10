using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.Migrations
{
    public partial class NullableEngineerId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Engineers_EngineerId",
                table: "Machines");

            migrationBuilder.AlterColumn<int>(
                name: "EngineerId",
                table: "Machines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Engineers_EngineerId",
                table: "Machines",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Engineers_EngineerId",
                table: "Machines");

            migrationBuilder.AlterColumn<int>(
                name: "EngineerId",
                table: "Machines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Engineers_EngineerId",
                table: "Machines",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
