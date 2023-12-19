using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorGeoMap.Migrations
{
    public partial class MigrationLocality5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IBGE", 
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 7, nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: true),
                    City = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IBGE", x => x.Id); 
                });

            migrationBuilder.CreateIndex(
                name: "IX_IBGE_State", 
                table: "IBGE",
                column: "State");

            migrationBuilder.CreateIndex(
                name: "IX_IBGE_City", 
                table: "IBGE",
                column: "City");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IBGE");
        }
    }
}
