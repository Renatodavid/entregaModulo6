using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entrega_modulo6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(228)", maxLength: 228, nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(228)", maxLength: 228, nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(228)", maxLength: 228, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "destino",
                columns: table => new
                {
                    DestinoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDestino = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Valor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DataChegada = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DataSaida = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    HoraChegada = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    CompraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_destino", x => x.DestinoId);
                    table.ForeignKey(
                        name: "FK_destino_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "compra",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ValorCompra = table.Column<string>(type: "nvarchar(110)", maxLength: 110, nullable: false),
                    DestinoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compra", x => x.CompraId);
                    table.ForeignKey(
                        name: "FK_compra_destino_DestinoId",
                        column: x => x.DestinoId,
                        principalTable: "destino",
                        principalColumn: "DestinoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_compra_DestinoId",
                table: "compra",
                column: "DestinoId");

            migrationBuilder.CreateIndex(
                name: "IX_destino_UsuarioId",
                table: "destino",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "compra");

            migrationBuilder.DropTable(
                name: "destino");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
