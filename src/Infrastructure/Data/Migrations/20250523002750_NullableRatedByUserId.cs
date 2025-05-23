using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class NullableRatedByUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RatedByUserId",
                table: "Ratings",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RatedByUserId",
                table: "Ratings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

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
    }
}
