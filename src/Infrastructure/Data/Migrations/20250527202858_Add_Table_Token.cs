using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_Table_Token : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OneTimeTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Token = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    Expiration = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsUsed = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OneTimeTokens", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$/fLu926cOfmjOTiQ5dt9yOp2BfLoTXYfHlqH78JLMQOeBcQQC2oqi");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$GpBIDM7gbDy9gH0kLiLOh.8VfRV.7hAyCedrreX58HeXfWgK3jr8m");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$2MqehDXhSYldtaa1K1bjMuDc.ZEDjVw6S3pdhmCH8xJgdKdxfU/Rq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$QdwI.sTEY3WW/WkJW2Y6eu5nyvHTQCD742sihZy2BEpWd.fCbmB1e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$hSHjIpRN/VoyjKSCy0kTjeBtGBPzL.lAvXHpCakGMS1uVBAhFwFnO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$8tGhAj3lcb7EU46T4JHgWOvGcLRLqvU6/eYaykXBaBWTiUAnlGoRK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OneTimeTokens");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$Mb6WkISgbNG3ZNsjVUb3w.vPOa.96bYRIeiDw7SZ4TmNy.WIXywBq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$JhHFLkJkxqWFRly0LUfkyemBTKB26PxtSlQZt9JJJuQOuVYMV/EhG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$GFVGmvvmuDi2CRHrY4O/AuHqM.zZMOEpoHoBixJq3nD4ZSJ3VMyz2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$tKMqzb24XGkGPwdDTkkyVu6eFRaiufZxt6V8zeK6CY9NGDbVu0IvK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$bjqDPRF8m6z4SlX.lztlLO.eVhu9q4DIuOeOL26vPeE11.s3vTUfO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$AlE5pTs4fRgXIc7MeTdrMOWX4u.I05YKxIpRqdU9VUuufvArLrS.C");
        }
    }
}
