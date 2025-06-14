using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedsWithPostulantSelected : Migration
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
                keyValue: 5,
                column: "PostulationSelectedId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$5bvH8tHXQcyNnLQ6awz8m.uaX3sqwFRt.cNkT.wl6iXhigDQ/XCrK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$bcdWoPxwT1QqKbeyTRifWuFz1kO/HrYMdvKmcll0BXzo65Qy2lndq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$I8K4NX6W2e591oh10o5ik.d/r856uMuJ1eo/tksvFnyXMy.Eds/nu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$MF21VbjqRyMWc62ULzTQKOebYxF6G/6t8bC7rnddMfJ2k/adpQ.Ny");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$FVIamuwEPYpnSf/Ut47lruDJ/CSBkH931h4zbZHK09MvRN5fZvlIm");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$NDlDgdPGWIWkBG.herTaLeCW/oumG0LJ2MpZVR40tylVlqGUxomoK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$4G/O4X/C5KdNdaMe173/LO3G2sfLWMBIaQpHMA44Y7plxxHDnhed6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$C30gyYWEvAIEpzHbcIVEEen4ccALGZKgY.7694NWzK0j4OuRj.JWG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$DTNlyZ78VlKE7FWLJ2usF.PJoFFJReG/Vvgc.vcmfEZZbN2VtBUw.");
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
                keyValue: 5,
                column: "PostulationSelectedId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$8lU1szEStHsHLQK1sN4ZKu/YKwY8FpMOmkIxazF4aVEWTBZwXuTVi");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$AGzQLZ6oj5tmayPVcCcLEedahAYJiZLWdB4NeN7RU2P2F6.29LHUO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$LuktQJRT5b/zekFoOrkM1uiECD3nRbIZZz4q1IZ8lVJFYcx0AhkEy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$Kr/WsIOFdqmva91Ze1exOuk3C27KpiKUjXrBdrdKLQU5.1sezz3a2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$rrxmrNZYCccdWObKu/GOZuOrrySBlYPEMiLvXpEs5n2ipG9.KGIwa");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$U.nbSNyIHgEoASosg2N9/OrmdqghH1Q.79Ha3phjV/3SR78kP1Weq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$7zTfXvOakzJ.yIVvWKSBz.BzgbbiJsX7WlMRNGtoHuMeVa7fyBt9O");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$4Y7rjf1zzA7ubI948sAlMeFkyKzQKlP4u7ZWcrKq/715P.29E7pQy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$bQiNDxIEum81JhGbaILCr.D2zx./xl0lZR6IQFUin.bwO7JimG6rm");
        }
    }
}
