using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedNewJobsWithPostulant : Migration
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
                value: "$2a$11$4N.f0ikpktdeWULqQ7OEpOkvutJScn9rYOa/6PpggiGla.FhXDKEG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$u9BOz7RwPUflw1GPa1AqEOKuhwnoTOuW017UBi/fma6L7G27WhpmK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$8jFwOMezmTxEn9qFnOaxue5khN0N5eicOrP1iF3XiPu0vHkTFcSDu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$vXckzsaQdrVQl2tHP/oZi.0ZZEGEazNI.LNHfkM0y8JUHaDywSSUy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$jt7rpxQh5S8Pv/SfHpkV7OCMUixO2Mth779EY4wtjOOHA/ZiG/AFK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$gY8sb4q4nlKc39qeU2Do3ehxMRTNn/KrrXXpORruCtQYlvVCMAahm");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$wdiSFB0PvrukajeIChQKI.3hN/D73aBZUYddNcBpsF8pOR2puQ83y");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$2P3wZrjA/W/1KtPuPlM7vubduLHKcOXQqT5grftMVgcHjAQLAG4bS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$6Z3n3e5Xz4YBtQKHpHlclOYVtr4GKG4GGbHmZXfSPc68PORKEkSF.");
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
    }
}
