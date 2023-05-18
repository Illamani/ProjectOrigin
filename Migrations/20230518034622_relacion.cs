using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectOrigin.Migrations
{
    public partial class relacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CuentaId",
                table: "Registros");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Registros");

            migrationBuilder.AddColumn<long>(
                name: "NumeroTarjeta",
                table: "Registros",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Tarjeta_NumeroTarjeta",
                table: "Tarjeta",
                column: "NumeroTarjeta");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Cuenta_NumeroTarjeta",
                table: "Cuenta",
                column: "NumeroTarjeta");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjeta_Cuenta_NumeroTarjeta",
                table: "Tarjeta",
                column: "NumeroTarjeta",
                principalTable: "Cuenta",
                principalColumn: "NumeroTarjeta",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarjeta_Cuenta_NumeroTarjeta",
                table: "Tarjeta");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Tarjeta_NumeroTarjeta",
                table: "Tarjeta");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Cuenta_NumeroTarjeta",
                table: "Cuenta");

            migrationBuilder.DropColumn(
                name: "NumeroTarjeta",
                table: "Registros");

            migrationBuilder.AddColumn<int>(
                name: "CuentaId",
                table: "Registros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Registros",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
