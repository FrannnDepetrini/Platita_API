using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class migForTest2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$65twPJDPZu0Eb6JoNq0uBewZMbDt5mmXmYIkCAkktWckMoyC.SLx6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$ICCwOL6k9hbaw5KnyGo4zuIgnISJGKK7.iDq9n2XxDR.Lg0B3DGw.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$a85RWLX.GX3M7ogGFZJmA.kugLFhwKPeXAbsnyb1UB5OMIk.5t0d6");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "PhoneNumber", "Role", "UserName" },
                values: new object[] { 200, "admin@test.com", "1234", "123456789", "Admin", "adminTest" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$BFPt5SNvHFZ0wBZGPnNMiOuMIwHc6.VxbQxPuD7FviHGdzJDbOSzi");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$cVgLehOI7d6D0OCcnmJbdOVyTW5WQ6fqSjbQIB1MHCgtCaP8DShmW");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$4JSoXbgpczTHrDKKwP9RA.QBhxmetDR2ONg84mjkb1Ms49/DSpNFS");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "PhoneNumber", "Role", "UserName" },
                values: new object[] { 1, "admin@test.com", "1234", "123456789", "Admin", "adminTest" });
        }
    }
}
