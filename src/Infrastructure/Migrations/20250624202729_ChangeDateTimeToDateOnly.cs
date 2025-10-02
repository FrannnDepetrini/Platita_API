using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDateTimeToDateOnly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateOnly(2025, 5, 24), new DateOnly(2025, 5, 15) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateOnly(2025, 5, 20), new DateOnly(2025, 5, 13) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateOnly(2025, 5, 18), new DateOnly(2025, 5, 15) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateOnly(2025, 5, 23), new DateOnly(2025, 5, 17) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateOnly(2025, 5, 22), new DateOnly(2025, 5, 17) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateOnly(2025, 5, 20), new DateOnly(2025, 5, 16) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateOnly(2025, 4, 26), new DateOnly(2025, 4, 21) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateOnly(2025, 5, 24), new DateOnly(2025, 5, 17) });

            migrationBuilder.UpdateData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobDay",
                value: new DateOnly(2025, 5, 23));

            migrationBuilder.UpdateData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobDay",
                value: new DateOnly(2025, 5, 22));

            migrationBuilder.UpdateData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobDay",
                value: new DateOnly(2025, 5, 16));

            migrationBuilder.UpdateData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobDay",
                value: new DateOnly(2025, 5, 17));

            migrationBuilder.UpdateData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 5,
                column: "JobDay",
                value: new DateOnly(2025, 5, 21));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateOnly(2025, 5, 28));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateOnly(2025, 5, 27));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateOnly(2025, 5, 25));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$dYtJVF6ONf0frxistL0/euUCP/Ntc8tRfMsD/xAH3YjRfZHoineTy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$.tBWvCSMzCZGgln4.JoUE.MXSvuGk5PehaybsgRXmbE9wgekmc1ly");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$yYUrhO2yTiTsJ6GoFp8Op.8MYT7Fm4C0sHcK1vDv0Pp3lds5rjoai");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$ItFg7RRJJT1V/CBi.bC/PelvvAelceFm89gUfui9mjC77DRUYyXeC");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$pRKB10dzvh9tpKsXD2dQmeaBjeA28ENR4SIUYCMjgxrxdmEpzVp5m");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$X7nA5NdXmqpo5IoEO2Hn3OgjOQ0Z8sZN2oogEpqKu/RcsBR7bZb/S");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$peeOYTC55Shg7s/zisJSVO.u/GFIJBO3RNeer1CKqFJIjou0lkCBO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$QMPxMN/S9UCdeXx2uEUGCeh8Aw3i46TJb3B4g00DQmuaYNtdmO/1W");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$GBM7fc4GPPjsyK86mPxi3uAFwL2qdpHdKsiVzaJ/CCQimyYIsW5dW");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobDay",
                value: new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobDay",
                value: new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobDay",
                value: new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobDay",
                value: new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 5,
                column: "JobDay",
                value: new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_At",
                value: new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_At",
                value: new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_At",
                value: new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
