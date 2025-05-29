using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedsWithPostulation : Migration
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
                keyValue: 4,
                column: "Password",
                value: "$2a$11$len05k4w5houjF87JQ0laeF3WBR3cXjDDcFAPUoTaETZvSFknjJfu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$aAbql5dXB/Oj3MDgKxWjpugEABpDetu7kPAGIuWXZYU6UjnZh0Ujq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$Lk6jslDT/mKHowtPDNWLw.MvA.mpx9OEAdV78TH.TO9VYXQWgE0oC");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$fGzM1qKnpnJKwO8Cw31JauMsn.rYc9Qjqx.87vie1Z2IRfXvJsFbS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$uvmVYeCcjWP/.MN0t0ZAs.EgMCl6IvVrONFGGQREtYj2xEnOzBXpC");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$g/PhDPHfGNOkfeP11.CI7OgVFNYZKWn0lOBGGG6C.mph.48gULJ2O");
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
                keyValue: 4,
                column: "Password",
                value: "$2a$11$CfbSAv//7Sy7KlTfgVITHe9Hkm16.8ibd.UU8mxFDTlZBTLUhDWJW");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$WSI7flznekce6WfzTv7fhOtypPO4JogIJ5HX2XPW80dyfBDIiLK/G");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$v7o2qWdBz7tB63Z4Pe89CuUW3KFuIa5dD.PCVV5xIovGReECuFM1a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$4kqg9yk4OgCcIq7fksQUKes5RZSv61Nu67srCImSbGpci8yRxPDoG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$teJ9CDRzkVZKQByAgMKS5u2cwlVWnV7XkGAgrXhjY5Yyp3rUG8JpC");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$oguOFQoITRdDaB6sk5Gk/.pZ8K61IyhiILk9gX6GQ8k409fXH8uiy");
        }
    }
}
