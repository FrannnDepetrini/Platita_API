using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedDateJobFinishedAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateJobFinished",
                table: "Jobs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateJobFinished",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateJobFinished",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateJobFinished",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateJobFinished",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateJobFinished",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateJobFinished",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateJobFinished",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateJobFinished",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$SVhtwXdRaiNsQqz.CZ58aOT1qSGuS10Lqhtz8MfzU3AFEKAmYhkQu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$ySOU0qO5JsG3lrPev2OaZuawjR3R/bpJImGnkm2xHYJe29oNRGu1i");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$6ekmp6FxHtyZI6qmZEMf5.kejjWm5PZZQ4WYXwOnM2wNnd9EX842a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$6TyHNYUBL50o8OnQUi.Kl.f7t/l3uriXM7CAjSKTA/y0yNF6dzXzq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$WGFZ7vt9bctUGc3AwkhX4.l42RDR7yxGndscktXHITDk2syrsQ.lK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$rBJVuFre8G8S/ZancCZ5SOPqiQ93E8/70xPS2a9QMAfSAa.uku7om");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$rthb0gKDo3tIByUwmaz4xeJRtih4yZA.WbzXqvJ/nBr2RCqFY.SP6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$IuQCBX8mt37Z0HFwChqdD.OTPpqU.VDAng2lBQeGhH/g8cR45WbNa");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$w35zDRJF1fmdV481TKQZO.BO.GcqjsJJvr0fDrIuXuWkvJbmr/JgC");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateJobFinished",
                table: "Jobs");

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
    }
}
