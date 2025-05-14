using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class migForTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "$2a$11$v4nO3utFdRzhBn/celeWI.AM62XtfQoPEhHl4xdBmdPMANbF3/MnO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$0J0q1qnCrOJsMn3mS3nQy.mdRiUbe5rAz0ZtkjPI2qgvuXmQugSkG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$dl2U0Xyg/Nix.CacXSHD.upmcrwFdeH.rC7QRyLwYVZCoWPl4rKIi");
        }
    }
}
