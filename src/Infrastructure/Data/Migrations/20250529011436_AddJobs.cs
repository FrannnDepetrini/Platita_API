using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddJobs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$1jyjKHUn5M6jZmu0bmKPZe44SL1TaR.6dCNpX98Z4a0kbO7m44p42");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$eCdMOPjbsttq68JkhKLk4u09a0kb6QZVCvqVNHWo5859ulLzD7JzO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$yHa.xvrTsIaSFBgmMuNY2.K0GaYLsqmtS6eN.Rmxxoz1nisExSCli");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$tTwDqePk8Q5zcKXsyx3IUekBuBt1j.utK78GDPd3vq4oL4T7mpC8G");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$nEhIxUWeZVvZGf.lzRO5M.sQOB/.quFNqdSlo/OGt0clsO/GTKNpy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$ew2ZLBSSLX0/OHzvkvYFP.wRlzukVkebY1h0HqLbPQ2tDvS/3Aovu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Postulations",
                columns: new[] { "Id", "Budget", "ClientId", "JobDay", "JobId", "Status" },
                values: new object[,]
                {
                    { 1, 15000f, 6, new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, 14000f, 7, new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0 },
                    { 3, 20000f, 4, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 0 },
                    { 4, 18000f, 8, new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 5, 22000f, 9, new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 0 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ClientId", "Description", "JobId", "RatedByUserId", "RatedUserId", "Score" },
                values: new object[,]
                {
                    { 1, null, "muy amable y hasta me ofrecio facturas.", 1, 7, 4, 4 },
                    { 2, null, "tipazo, muy prolijo!", 1, 4, 7, 5 },
                    { 3, null, "estaba de mal humor y me trato bastante mal", 3, 4, 5, 1 },
                    { 4, null, "me dejo el patio hecho un desastre", 3, 5, 4, 1 },
                    { 5, null, "el baño estaba un poco sucio. buen trato!", 4, 9, 6, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$y1uFioL1tSC4AxjgqyGiv.Cjw9bDu2AmaxsjyP7wBLCF72cFLyKLa");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$gP9l7qNFM8FLV9l.8AJNxOql3DEqHkBbidp4RWlz9O.OxWW.s3zy2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$yTPuncjT1IddDWD5G.Tlnuljalb5mfyrNrRmmi88nEazohE3EnbPa");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$WcWXC7AopHLZGOvwqnoUEOhNHcK0Ps0GJC4/ldRYMf64wz0sHCTuK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$gv9ZtI4ZtIesQWzUNBHXzub18cHLkS05g8GNsCFyoDeT.CLjFlauu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$ndjPdDeCFMotZyp3qY4b4uuBfw5Si.8/Zj7SfTTyW9ZzE5oQNo772");
        }
    }
}
