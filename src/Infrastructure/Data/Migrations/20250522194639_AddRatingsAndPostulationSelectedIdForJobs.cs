using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRatingsAndPostulationSelectedIdForJobs : Migration
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
                value: "$2a$11$Q7n7IO67ooRiDtnDAf/.deaZkbsoBwrs2l9Dc7LgYGdeNSAcqP3Tu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$YAe24HYdpqE6tak8nmh56.4B51cMOTQaOVydjZBA0MXV1TpPa6yvG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$Aacn57xLsHkC3rc6TIcbzeLeYj6w2kCa5sdNaqSJKd4bu4ky5YEse");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$fbeRcO7.aOZ0U2qeArDAEecI/QI.HzdogvSDFK44g.o4FnHplR5T6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$zHlnUvY82UYkvpxC9V68hu3/IpXJNVolTHXyodTGHJVa/nVwdZSRG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$8LG9AovzMxYp8iUF7hrdte7XWqpTnWf4BsgQR.A1wSosrDkQlSidS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                value: "$2a$11$gvHVlHiREWJLfQeGp1b2VOw6JN00ujw4yafyK1SUofNp1nmM.mZwG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$g7re2zUETmIhWH8W1mtxqucxlwgMUoxbW/SIYHzYxxttHC6uonxuy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$TyL/v04ux2WndlnlEz8ou./LfYDPIrZV31Rqz4axy6IINvEk39fTC");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$eG7Jq.HX.hErj8IKOrvnAuNV7N.W3ndBwVJoBvCfpDRDcvEZOCvqu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$cNiVRrkfafCmRLJyOcbTtuoL4t8gdzY/Bx.CuP/PX3q1Y.G/lEWZe");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$uxWvXMILhSutRtHtv4nhvetHa8052e2ZySB0iWem3wm6NNkP1Hnnm");
        }
    }
}
