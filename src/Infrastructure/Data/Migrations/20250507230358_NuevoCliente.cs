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
                values: new object[] { "$2a$11$I4kaU587/nd8O9pQPItBx.WynU/uQCnbAYoFW5c3udxmkntBBaOIm", 3.4965025E+09f });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Email", "Password", "PaymentId", "PhoneNumber", "Role", "Province", "UserName" },
                values: new object[,]
                {
                    { 6, "La Plata", "joako.tanlon@gmail.com", "$2a$11$EwrulhaYqrUbUR2YDaQEf.d0Ez5viPNNnzaN3E/fe9AZAa2zurDQm", null, 3.412123E+09f, "Client", "Buenos Aires", "Joaquin" },
                    { 7, "Rosario", "marucomass@gmail.com", "$2a$11$5yeRvqH2bkOcaar4OnPB2Op4Q2.8v43JdIQdswiQeULf3Io0OFAQe", null, 3.4676372E+09f, "Client", "Santa Fe", "Mario" }
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
