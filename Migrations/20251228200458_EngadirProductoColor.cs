using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TendaNET.Migrations
{
    /// <inheritdoc />
    public partial class EngadirProductoColor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Productos");
        }
    }
}
