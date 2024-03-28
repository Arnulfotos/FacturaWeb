using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FacturaWeb.Migrations
{
    /// <inheritdoc />
    public partial class BindProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacturaDetalle_Factura_FacturaID",
                table: "FacturaDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaDetalle_Producto_ProductoID",
                table: "FacturaDetalle");

            migrationBuilder.AlterColumn<int>(
                name: "ProductoID",
                table: "FacturaDetalle",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FacturaID",
                table: "FacturaDetalle",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaDetalle_Factura_FacturaID",
                table: "FacturaDetalle",
                column: "FacturaID",
                principalTable: "Factura",
                principalColumn: "FacturaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaDetalle_Producto_ProductoID",
                table: "FacturaDetalle",
                column: "ProductoID",
                principalTable: "Producto",
                principalColumn: "ProductoID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacturaDetalle_Factura_FacturaID",
                table: "FacturaDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_FacturaDetalle_Producto_ProductoID",
                table: "FacturaDetalle");

            migrationBuilder.AlterColumn<int>(
                name: "ProductoID",
                table: "FacturaDetalle",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "FacturaID",
                table: "FacturaDetalle",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaDetalle_Factura_FacturaID",
                table: "FacturaDetalle",
                column: "FacturaID",
                principalTable: "Factura",
                principalColumn: "FacturaID");

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaDetalle_Producto_ProductoID",
                table: "FacturaDetalle",
                column: "ProductoID",
                principalTable: "Producto",
                principalColumn: "ProductoID");
        }
    }
}
