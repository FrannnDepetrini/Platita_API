using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameStateToProvince : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "State",  // Nombre actual de la columna
                table: "Jobs",  // Tabla donde está la columna
                newName: "Province");  // Nombre nuevo de la columna

            // Si es necesario, también actualizá la columna en Down()
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Province",  // Nuevo nombre de la columna
                table: "Jobs",     // Tabla donde está la columna
                newName: "State"); // Nombre original de la columna
        }
    }
}
