using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectOrigin.Migrations
{
    public partial class IncorporacionDeCuenta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CuentaId",
                table: "Tarjeta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cuenta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Balance = table.Column<double>(type: "float", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    NumeroTarjeta = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuenta", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tarjeta_CuentaId",
                table: "Tarjeta",
                column: "CuentaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjeta_Cuenta_CuentaId",
                table: "Tarjeta",
                column: "CuentaId",
                principalTable: "Cuenta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarjeta_Cuenta_CuentaId",
                table: "Tarjeta");

            migrationBuilder.DropTable(
                name: "Cuenta");

            migrationBuilder.DropIndex(
                name: "IX_Tarjeta_CuentaId",
                table: "Tarjeta");

            migrationBuilder.DropColumn(
                name: "CuentaId",
                table: "Tarjeta");
        }
    }
}
