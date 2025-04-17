using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigrationForTestingEndpointPut : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployerName",
                table: "Jobs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "EmployerName" },
                values: new object[] { new DateTime(2025, 4, 17, 12, 2, 43, 473, DateTimeKind.Local).AddTicks(9908), "Juan" });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTime", "EmployerName" },
                values: new object[] { new DateTime(2025, 4, 17, 12, 2, 43, 473, DateTimeKind.Local).AddTicks(9925), "Maria" });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Available", "Category", "DateTime", "Description", "EmployerName", "Location", "Title" },
                values: new object[] { 3, true, 4, new DateTime(2025, 4, 17, 12, 2, 43, 473, DateTimeKind.Local).AddTicks(9928), "necesito cortar el pasto", "Marta", "Buenos Aires", "Busco Jardinero" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "EmployerName",
                table: "Jobs");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2025, 4, 16, 20, 23, 3, 838, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2025, 4, 16, 20, 23, 3, 838, DateTimeKind.Local).AddTicks(1105));
        }
    }
}
