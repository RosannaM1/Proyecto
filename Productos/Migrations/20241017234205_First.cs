using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Productos.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    CodigoProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionProducto = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    CostoProducto = table.Column<decimal>(type: "money", nullable: false),
                    PrecioProducto = table.Column<decimal>(type: "money", nullable: false),
                    ExistenciaProducto = table.Column<int>(type: "int", nullable: false),
                    EstatusProducto = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.CodigoProducto);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
