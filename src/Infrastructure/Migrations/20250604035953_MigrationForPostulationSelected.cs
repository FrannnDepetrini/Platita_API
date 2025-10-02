using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MigrationForPostulationSelected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostulationSelectedId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostulationSelectedId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostulationSelectedId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$1bJMxIuOOd.BEDOVeTmf8.BX5D/WPgSX/4mSMMef24vh4SVB6XUfi");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$Qo8mczr0dy.lznYPfvvkOeXEs/HUotPERYJ.FSqxBfc4jFXo5qSza");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$ub4kkJHYd0evvKycoywX7u/TYFGl98ZmoCQGrxz.T25dsASuECcBG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$OCZCPMinj54gwyGdIqxOz.dbwZnGVOfhF6e2FrShY/U.HvSyENaBq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$8qoJRK5kzG.jq8Ilypu8JeMsxaQ9nnIz0cTeKMlcFNblIoy9cN/hW");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$PH9hYlqg40HiAu.c4ZsDc.L1FSu6MbhNkezj6/EHO9zKxJ9Y3bsty");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$3lHs3shV9uY5wqAi.SMJcORCDsfY3wtV0mXYA487XBaUwo5OiNxw2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$GG0VfUTVsT4uqUttat3qW.Icydh3WLFjxdr.KJxAysetVQcMgaJla");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$RP4syRjJj/0jwiS1vuuzl.9xXQi4uAJVPiKA9n.G8EUx.EJxPOLNy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostulationSelectedId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostulationSelectedId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostulationSelectedId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$xn2eIPdvb9wgYnQiz3iizuQ50tt.nwQrr46xnnAcoMw791ZdKbWGq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$59FQPCw8hwKq1EdZV5iXpO7Y65lb3Wvgajto3S3CcW24U3rfnVgi.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$wqdHCv4.EqC/tI8vFBcQ5uDLUMeS0Vh96l2GcfgqvS1JDZhEY6i6C");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$KEPDwRX05iMJvOJnR1E6Z.IlB2d5JZORYS0De3r86n2omOikkK7hi");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$5yf4GR1MiayiLE2SKScB.uzv5f6ufr/IfPvAPMrVqAIlnmgNeuAde");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$d7Mns6UQ5cj.Ix4AzlTgWuQtfjgneO6uzShh0NCwILJNl2RWUnCti");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$AgNPiGrSx7lCUfivSyRe3.tmrWKFVtHsP7O0uza/wM6uYSmcn9r8W");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$pY2X1LbuC97ycUN0Q4C.xumai4FmDAzuQmSIxJdGk0CLC9xKEn0s2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$HUC4ny922vfKrRGvFUjm.OZbAJoPTRZgOiBYc0Xx7aW5ZXhWyTWfe");
        }
    }
}
