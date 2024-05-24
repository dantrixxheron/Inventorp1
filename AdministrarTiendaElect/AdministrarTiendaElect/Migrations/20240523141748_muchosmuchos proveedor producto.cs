using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdministrarTiendaElect.Migrations
{
    /// <inheritdoc />
    public partial class muchosmuchosproveedorproducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductoProveedor",
                columns: table => new
                {
                    ProductosID_Producto = table.Column<int>(type: "int", nullable: false),
                    ProveedoresID_Proveedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoProveedor", x => new { x.ProductosID_Producto, x.ProveedoresID_Proveedor });
                    table.ForeignKey(
                        name: "FK_ProductoProveedor_Productos_ProductosID_Producto",
                        column: x => x.ProductosID_Producto,
                        principalTable: "Productos",
                        principalColumn: "ID_Producto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductoProveedor_Proveedores_ProveedoresID_Proveedor",
                        column: x => x.ProveedoresID_Proveedor,
                        principalTable: "Proveedores",
                        principalColumn: "ID_Proveedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductoProveedor_ProveedoresID_Proveedor",
                table: "ProductoProveedor",
                column: "ProveedoresID_Proveedor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductoProveedor");
        }
    }
}
