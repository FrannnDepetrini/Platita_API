using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class NuevoCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "PhoneNumber",
                table: "Users",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "PhoneNumber" },
                values: new object[] { "$2a$11$tIV6DXe.ShRbz9.ug0euWOk9rtSnkry4jsIo6HXAZWU/.oiQDXaFC", 3.4965025E+09f });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Email", "Password", "PaymentId", "PhoneNumber", "Role", "State", "UserName" },
                values: new object[,]
                {
                    { 6, "La Plata", "joako.tanlon@gmail.com", "$2a$11$nXNyRCvy/Hn7h6KUK8veEONsqe.uzBGTrAG/J1yKfBPTSm3Bl1oZy", null, 3.412123E+09f, "Client", "Buenos Aires", "Joaquin" },
                    { 7, "Rosario", "marucomass@gmail.com", "$2a$11$DyBYyv9cASZBFoz0cbU6IuUPHTBYKwtS6oHIf4rAWpFk9O2kQpykC", null, 3.4676372E+09f, "Client", "Santa Fe", "Mario" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "PhoneNumber" },
                values: new object[] { "1234", 341 });
        }
    }
}
