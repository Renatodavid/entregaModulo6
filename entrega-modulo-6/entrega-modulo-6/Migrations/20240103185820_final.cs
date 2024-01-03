using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entrega_modulo6.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_compra_destino_DestinoId",
                table: "compra");

            migrationBuilder.DropForeignKey(
                name: "FK_destino_Usuarios_UsuarioId",
                table: "destino");

            migrationBuilder.DropIndex(
                name: "IX_destino_UsuarioId",
                table: "destino");

            migrationBuilder.DropColumn(
                name: "CompraId",
                table: "destino");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "destino");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "destino");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioModelUsuarioId",
                table: "destino",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_destino_UsuarioModelUsuarioId",
                table: "destino",
                column: "UsuarioModelUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_compra_destino_DestinoId",
                table: "compra",
                column: "DestinoId",
                principalTable: "destino",
                principalColumn: "DestinoId");

            migrationBuilder.AddForeignKey(
                name: "FK_destino_Usuarios_UsuarioModelUsuarioId",
                table: "destino",
                column: "UsuarioModelUsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_compra_destino_DestinoId",
                table: "compra");

            migrationBuilder.DropForeignKey(
                name: "FK_destino_Usuarios_UsuarioModelUsuarioId",
                table: "destino");

            migrationBuilder.DropIndex(
                name: "IX_destino_UsuarioModelUsuarioId",
                table: "destino");

            migrationBuilder.DropColumn(
                name: "UsuarioModelUsuarioId",
                table: "destino");

            migrationBuilder.AddColumn<int>(
                name: "CompraId",
                table: "destino",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "destino",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "destino",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_destino_UsuarioId",
                table: "destino",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_compra_destino_DestinoId",
                table: "compra",
                column: "DestinoId",
                principalTable: "destino",
                principalColumn: "DestinoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_destino_Usuarios_UsuarioId",
                table: "destino",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
