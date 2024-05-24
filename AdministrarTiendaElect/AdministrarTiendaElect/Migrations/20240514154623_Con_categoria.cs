using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdministrarTiendaElect.Migrations
{
    /// <inheritdoc />
    public partial class Con_categoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID_Categoria",
                table: "Productos",
                newName: "CategoriaID_Categoria");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Categorias",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaID_Categoria",
                table: "Productos",
                column: "CategoriaID_Categoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_CategoriaID_Categoria",
                table: "Productos",
                column: "CategoriaID_Categoria",
                principalTable: "Categorias",
                principalColumn: "ID_Categoria",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_CategoriaID_Categoria",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_CategoriaID_Categoria",
                table: "Productos");

            migrationBuilder.RenameColumn(
                name: "CategoriaID_Categoria",
                table: "Productos",
                newName: "ID_Categoria");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
