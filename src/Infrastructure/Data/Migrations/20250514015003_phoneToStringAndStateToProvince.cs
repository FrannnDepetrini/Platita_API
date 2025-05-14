using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class phoneToStringAndStateToProvince : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Postulations",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "PhoneNumber" },
                values: new object[] { "$2a$11$v4nO3utFdRzhBn/celeWI.AM62XtfQoPEhHl4xdBmdPMANbF3/MnO", "3496502453" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Password", "PhoneNumber" },
                values: new object[] { "$2a$11$0J0q1qnCrOJsMn3mS3nQy.mdRiUbe5rAz0ZtkjPI2qgvuXmQugSkG", "3412122907" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Password", "PhoneNumber" },
                values: new object[] { "$2a$11$dl2U0Xyg/Nix.CacXSHD.upmcrwFdeH.rC7QRyLwYVZCoWPl4rKIi", "3467637190" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Postulations",
                newName: "id");

            migrationBuilder.AlterColumn<float>(
                name: "PhoneNumber",
                table: "Users",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "PhoneNumber" },
                values: new object[] { "$2a$11$I4kaU587/nd8O9pQPItBx.WynU/uQCnbAYoFW5c3udxmkntBBaOIm", 3.4965025E+09f });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Password", "PhoneNumber" },
                values: new object[] { "$2a$11$EwrulhaYqrUbUR2YDaQEf.d0Ez5viPNNnzaN3E/fe9AZAa2zurDQm", 3.412123E+09f });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Password", "PhoneNumber" },
                values: new object[] { "$2a$11$5yeRvqH2bkOcaar4OnPB2Op4Q2.8v43JdIQdswiQeULf3Io0OFAQe", 3.4676372E+09f });
        }
    }
}
