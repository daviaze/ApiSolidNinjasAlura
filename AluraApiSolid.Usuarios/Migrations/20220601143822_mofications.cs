using Microsoft.EntityFrameworkCore.Migrations;

namespace AluraApiSolid.Usuarios.Migrations
{
    public partial class mofications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb34cb04-871d-4f00-ab8b-e79e1c49d06c", "normal", "NORMAL" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "66cd290b-78f0-4668-ba7c-5b5f12380e2b", "regular", "REGULAR" });
        }
    }
}
