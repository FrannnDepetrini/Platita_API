using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class JOBDAYaddinPostulation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "JobDay",
                table: "Postulations",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$62/ktj3.pWYpPSxoTfIVceKpmBP8eEaynOd1tTR2dWtLBp0KlXE76");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$OsXpT8tGJICtNJ9rfEGhReMfUz3Bwns8st/rcfH08fjkujH6HUOwa");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$okz6lEDGJpQoVSEH2/8v8e9l4kv5YJXKXBXVlC/d429Hojg21jJlG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$hx9mYrEhXpxjepo/oB9omO.nidHD5bW7bFHP3ab65gmm5UHkouvLi");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$7zFrfm79NSWLUKbqVCRdHe1ms3K5.54dU5sskhqAJMYzvK6KQY2JG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$h7llnqtbrY9ugyt0uxO/r.RpWIDnxV52SJbKIx.UDFHyG/U4RFQ3a");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobDay",
                table: "Postulations");

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
    }
}
