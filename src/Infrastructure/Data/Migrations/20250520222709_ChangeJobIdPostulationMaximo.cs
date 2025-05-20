using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeJobIdPostulationMaximo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$RuEr23Bctx0CbT6JYrYUse7CCU94SG8nYwhCdmlKz/6YNSJcKaeUi");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$e4q9lU69thWsFIGPaObkO.H7cLi0ykZSvHhlTwlvJiVEMrVGJm/DC");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$Ir9f0SCAD0tqFZIEGeWyeOwJHhpvqWKu84KMTKZWqItJyhkNgVE8m");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$6R3WsIpEyMlsYMNgTzbE/OkVyLEbTLUpasATzDI7q37cGrEJpocNG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$4jYOJNLsUbya69urkBpHOO5pR53hnU532xLLCKbLHQKKbJlqOF/8a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$fgwPSIi2V6NobJmBGAmWceL1rziedxMn8J8fYcWnLe2y.lCDikYZm");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$20pZvF83Bzj1cjftOkUoM.NMf1g8A2YK0nSj/.ZaiLTv5iYB/dxpy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$hhiJ1urmElC2Fl6UE.5lTeVdV1V.qdrkDpQL25oQ46wpdjSUsrlhS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$aXwKDKXWLgzKN4GSb12JyeaLoQxFi6eoz7BuGiXxeDPsMCf5FNPCi");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$doQsvM5noU5TSEniFJtFGOyS4Gwcd39v//3BWxdBklmnbMndAZUtu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$gfgOnamkhSemvDP4Fs3nnudyJElJsZDERk6wfQePDkI8TgUPPXiHW");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$u4WyRln9rHektWKi//3QduucAUgdvffzTzqMqFb3LrCzWniJqSH6e");
        }
    }
}
