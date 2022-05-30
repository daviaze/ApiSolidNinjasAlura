using Microsoft.EntityFrameworkCore.Migrations;

namespace AluraApiSolid.Migrations
{
    public partial class att : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ninjas_Vila_VilaId",
                table: "Ninjas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vila",
                table: "Vila");

            migrationBuilder.RenameTable(
                name: "Vila",
                newName: "Vilas");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cla",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vilas",
                table: "Vilas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ninjas_Vilas_VilaId",
                table: "Ninjas",
                column: "VilaId",
                principalTable: "Vilas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ninjas_Vilas_VilaId",
                table: "Ninjas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vilas",
                table: "Vilas");

            migrationBuilder.RenameTable(
                name: "Vilas",
                newName: "Vila");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cla",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vila",
                table: "Vila",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ninjas_Vila_VilaId",
                table: "Ninjas",
                column: "VilaId",
                principalTable: "Vila",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
