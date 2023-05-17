using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectOrigin.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarjeta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    NumeroTarjeta = table.Column<int>(type: "int", nullable: false),
                    PIN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarjeta", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarjeta");
        }
    }
}
