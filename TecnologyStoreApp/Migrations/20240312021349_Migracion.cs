using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TecnologyStoreApp.Migrations
{
    /// <inheritdoc />
    public partial class Migracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetallesFacturas",
                columns: table => new
                {
                    FacturaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombreCliente = table.Column<string>(type: "TEXT", nullable: false),
                    direccionEntrega = table.Column<string>(type: "TEXT", nullable: false),
                    nombreProductoSeleccionado = table.Column<string>(type: "TEXT", nullable: false),
                    colorSeleccionado = table.Column<string>(type: "TEXT", nullable: false),
                    cantidadSeleccionada = table.Column<int>(type: "INTEGER", nullable: false),
                    precioProductoSeleccionado = table.Column<decimal>(type: "TEXT", nullable: false),
                    totalApagar = table.Column<decimal>(type: "TEXT", nullable: false),
                    metodoPago = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesFacturas", x => x.FacturaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesFacturas");
        }
    }
}
