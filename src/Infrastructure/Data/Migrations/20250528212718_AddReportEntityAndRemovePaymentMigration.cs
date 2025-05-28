using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddReportEntityAndRemovePaymentMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Payments_PaymentId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Payments_PaymentId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Users_PaymentId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_PaymentId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Jobs");

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Created_At = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CategoryReport = table.Column<int>(type: "INTEGER", nullable: false),
                    JobId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reports_Users_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$y1uFioL1tSC4AxjgqyGiv.Cjw9bDu2AmaxsjyP7wBLCF72cFLyKLa");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$gP9l7qNFM8FLV9l.8AJNxOql3DEqHkBbidp4RWlz9O.OxWW.s3zy2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$yTPuncjT1IddDWD5G.Tlnuljalb5mfyrNrRmmi88nEazohE3EnbPa");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$WcWXC7AopHLZGOvwqnoUEOhNHcK0Ps0GJC4/ldRYMf64wz0sHCTuK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$gv9ZtI4ZtIesQWzUNBHXzub18cHLkS05g8GNsCFyoDeT.CLjFlauu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$ndjPdDeCFMotZyp3qY4b4uuBfw5Si.8/Zj7SfTTyW9ZzE5oQNo772");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ClientId",
                table: "Reports",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_JobId",
                table: "Reports",
                column: "JobId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Users",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Jobs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaymentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "PaymentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "PaymentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                column: "PaymentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7,
                column: "PaymentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 8,
                column: "PaymentId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { 1, "Pagos digitales a través de MercadoPago. Rápido y seguro.", 0 },
                    { 2, "Transferencia bancaria directa a la cuenta indicada por el usuario.", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "PaymentId" },
                values: new object[] { "$2a$11$/fLu926cOfmjOTiQ5dt9yOp2BfLoTXYfHlqH78JLMQOeBcQQC2oqi", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Password", "PaymentId" },
                values: new object[] { "$2a$11$GpBIDM7gbDy9gH0kLiLOh.8VfRV.7hAyCedrreX58HeXfWgK3jr8m", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Password", "PaymentId" },
                values: new object[] { "$2a$11$2MqehDXhSYldtaa1K1bjMuDc.ZEDjVw6S3pdhmCH8xJgdKdxfU/Rq", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Password", "PaymentId" },
                values: new object[] { "$2a$11$QdwI.sTEY3WW/WkJW2Y6eu5nyvHTQCD742sihZy2BEpWd.fCbmB1e", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Password", "PaymentId" },
                values: new object[] { "$2a$11$hSHjIpRN/VoyjKSCy0kTjeBtGBPzL.lAvXHpCakGMS1uVBAhFwFnO", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Password", "PaymentId" },
                values: new object[] { "$2a$11$8tGhAj3lcb7EU46T4JHgWOvGcLRLqvU6/eYaykXBaBWTiUAnlGoRK", null });

            migrationBuilder.CreateIndex(
                name: "IX_Users_PaymentId",
                table: "Users",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_PaymentId",
                table: "Jobs",
                column: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Payments_PaymentId",
                table: "Jobs",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Payments_PaymentId",
                table: "Users",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id");
        }
    }
}
