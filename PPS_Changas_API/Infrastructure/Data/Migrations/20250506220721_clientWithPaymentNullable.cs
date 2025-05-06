using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class clientWithPaymentNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Payments_PaymentId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Payments_PaymentId",
                table: "Users",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Payments_PaymentId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Payments_PaymentId",
                table: "Users",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
