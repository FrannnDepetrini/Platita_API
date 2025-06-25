using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedNewJobs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart", "PostulationSelectedId", "Status" },
                values: new object[] { new DateOnly(2025, 7, 24), new DateOnly(2025, 7, 15), null, 3 });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateOnly(2025, 7, 20), new DateOnly(2025, 7, 13) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart", "PostulationSelectedId", "Status" },
                values: new object[] { new DateOnly(2025, 7, 18), new DateOnly(2025, 7, 15), null, 3 });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart", "PostulationSelectedId", "Status" },
                values: new object[] { new DateOnly(2025, 7, 23), new DateOnly(2025, 7, 17), null, 3 });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateOnly(2025, 7, 22), new DateOnly(2025, 7, 17) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateOnly(2025, 7, 20), new DateOnly(2025, 7, 16) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateOnly(2025, 7, 26), new DateOnly(2025, 7, 21) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart" },
                values: new object[] { new DateOnly(2025, 7, 24), new DateOnly(2025, 7, 17) });

            migrationBuilder.UpdateData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobDay",
                value: new DateOnly(2025, 7, 22));

            migrationBuilder.UpdateData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobDay",
                value: new DateOnly(2025, 7, 16));

            migrationBuilder.UpdateData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 5,
                column: "JobDay",
                value: new DateOnly(2025, 7, 21));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$oYbcBz/fawCcP0w4eNC7..NIqFXvMlmICeZHd019alIr4RGiJKlfm");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$JxHYwil6km1Um/MSw8/WIe/XFZLgrqj5EXthUONu23tWTSmw.0CnO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$mqFLJsFkL8MlxYLkzr9bLOpqsHm10Pv6XSlK.vEUXbtUFgSB9AA3i");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$cMXiAm5XMP4vKcwm7rI/w.UpwXhUO34lmhJnZR9WiN0vBy9VFg7fS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$MwxFVY1y2fHQNSP3bScaieArvCLAZMjB2/juo0ACoJH2roPL31APC");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$i7/fdPNMt6kn5KDiNdAEHOTYRon1LmtQRONZ/mw3hjuDrluHyVc/q");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$M3SmZJzz18CtXzhKeXT2dupEuAydKfQ7iWz9FX4VSFvEv8MYGtSli");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$kPqxGJ.32UVotyYQBrYkzeZR4Dg6Vkinwg50ZRsRQDR8GkkS7zEam");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$74/QIEyFU4ano2ynOEi0Ue502VD.fjhyPtOWGHVXmCpLlZFq1d10i");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart", "PostulationSelectedId", "Status" },
                values: new object[] { new DateOnly(2025, 5, 24), new DateOnly(2025, 5, 15), 2, 0 });

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
                columns: new[] { "DayPublicationEnd", "DayPublicationStart", "PostulationSelectedId", "Status" },
                values: new object[] { new DateOnly(2025, 5, 18), new DateOnly(2025, 5, 15), 3, 0 });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DayPublicationEnd", "DayPublicationStart", "PostulationSelectedId", "Status" },
                values: new object[] { new DateOnly(2025, 5, 23), new DateOnly(2025, 5, 17), 5, 0 });

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
                keyValue: 5,
                column: "JobDay",
                value: new DateOnly(2025, 5, 21));

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
    }
}
