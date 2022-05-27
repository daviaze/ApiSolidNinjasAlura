using Microsoft.EntityFrameworkCore.Migrations;

namespace AluraApiSolid.Migrations
{
    public partial class AlterandoValidacoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ninjas_Cla_ClaId",
                table: "Ninjas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ninjas_Vila_VilaId",
                table: "Ninjas");

            migrationBuilder.AlterColumn<int>(
                name: "VilaId",
                table: "Ninjas",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClaId",
                table: "Ninjas",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ninjas_Cla_ClaId",
                table: "Ninjas",
                column: "ClaId",
                principalTable: "Cla",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ninjas_Vila_VilaId",
                table: "Ninjas",
                column: "VilaId",
                principalTable: "Vila",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ninjas_Cla_ClaId",
                table: "Ninjas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ninjas_Vila_VilaId",
                table: "Ninjas");

            migrationBuilder.AlterColumn<int>(
                name: "VilaId",
                table: "Ninjas",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ClaId",
                table: "Ninjas",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Ninjas_Cla_ClaId",
                table: "Ninjas",
                column: "ClaId",
                principalTable: "Cla",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ninjas_Vila_VilaId",
                table: "Ninjas",
                column: "VilaId",
                principalTable: "Vila",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
