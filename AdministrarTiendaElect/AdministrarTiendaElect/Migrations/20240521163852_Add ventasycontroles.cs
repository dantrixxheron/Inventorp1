using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdministrarTiendaElect.Migrations
{
    /// <inheritdoc />
    public partial class Addventasycontroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VentaControles",
                columns: table => new
                {
                    ID_Ticket = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentaControles", x => x.ID_Ticket);
                });

            migrationBuilder.CreateTable(
                name: "VentaDetalles",
                columns: table => new
                {
                    ID_Venta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hora = table.Column<TimeOnly>(type: "time", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductoID_Producto = table.Column<int>(type: "int", nullable: false),
                    VentaControlID_Ticket = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentaDetalles", x => x.ID_Venta);
                    table.ForeignKey(
                        name: "FK_VentaDetalles_Productos_ProductoID_Producto",
                        column: x => x.ProductoID_Producto,
                        principalTable: "Productos",
                        principalColumn: "ID_Producto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VentaDetalles_VentaControles_VentaControlID_Ticket",
                        column: x => x.VentaControlID_Ticket,
                        principalTable: "VentaControles",
                        principalColumn: "ID_Ticket",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VentaDetalles_ProductoID_Producto",
                table: "VentaDetalles",
                column: "ProductoID_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_VentaDetalles_VentaControlID_Ticket",
                table: "VentaDetalles",
                column: "VentaControlID_Ticket");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VentaDetalles");

            migrationBuilder.DropTable(
                name: "VentaControles");
        }
    }
}
