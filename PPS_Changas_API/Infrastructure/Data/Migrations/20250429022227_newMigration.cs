using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Users_EmployerId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Postulation_Jobs_JobId",
                table: "Postulation");

            migrationBuilder.DropForeignKey(
                name: "FK_Postulation_Users_EmployeeId",
                table: "Postulation");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Users_EmployeeId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Users_EmployerId",
                table: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_Rating_EmployeeId",
                table: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_EmployerId",
                table: "Jobs");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Rating");

            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "EmployerId",
                table: "Rating",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_EmployerId",
                table: "Rating",
                newName: "IX_Rating_ClientId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Postulation",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Postulation_EmployeeId",
                table: "Postulation",
                newName: "IX_Postulation_ClientId");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Jobs",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "EmployerName",
                table: "Jobs",
                newName: "Picture");

            migrationBuilder.RenameColumn(
                name: "Available",
                table: "Jobs",
                newName: "Status");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Users",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "Rating",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RatedByUserId",
                table: "Rating",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RatedUserId",
                table: "Rating",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "JobId",
                table: "Postulation",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Jobs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Jobs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PostulationSelected",
                table: "Jobs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Complaint",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false),
                    SupportId = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Complaint_Users_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Complaint_Users_SupportId",
                        column: x => x.SupportId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_PaymentId",
                table: "Users",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_JobId",
                table: "Rating",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_ClientId",
                table: "Jobs",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_ClientId",
                table: "Complaint",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_SupportId",
                table: "Complaint",
                column: "SupportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Users_ClientId",
                table: "Jobs",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Postulation_Jobs_JobId",
                table: "Postulation",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Postulation_Users_ClientId",
                table: "Postulation",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Jobs_JobId",
                table: "Rating",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Users_ClientId",
                table: "Rating",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Payment_PaymentId",
                table: "Users",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Users_ClientId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Postulation_Jobs_JobId",
                table: "Postulation");

            migrationBuilder.DropForeignKey(
                name: "FK_Postulation_Users_ClientId",
                table: "Postulation");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Jobs_JobId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Users_ClientId",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Payment_PaymentId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Complaint");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Users_PaymentId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Rating_JobId",
                table: "Rating");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_ClientId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Rating");

            migrationBuilder.DropColumn(
                name: "RatedByUserId",
                table: "Rating");

            migrationBuilder.DropColumn(
                name: "RatedUserId",
                table: "Rating");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "PostulationSelected",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Rating",
                newName: "EmployerId");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_ClientId",
                table: "Rating",
                newName: "IX_Rating_EmployerId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Postulation",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Postulation_ClientId",
                table: "Postulation",
                newName: "IX_Postulation_EmployeeId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Jobs",
                newName: "Available");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Jobs",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "Jobs",
                newName: "EmployerName");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Rating",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JobId",
                table: "Postulation",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "Jobs",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Available", "Category", "DateTime", "Description", "EmployerId", "EmployerName", "Location", "Title" },
                values: new object[,]
                {
                    { 1, true, 2, new DateTime(2025, 4, 23, 18, 30, 17, 6, DateTimeKind.Local).AddTicks(8930), "busco electricista para que me cambie una lamparita", null, "Juan", "Rosario", "Busco electricista" },
                    { 2, true, 1, new DateTime(2025, 4, 23, 18, 30, 17, 6, DateTimeKind.Local).AddTicks(8944), "busco plomero para arreglar mi bano", null, "Maria", "Rosario", "Busco plomero" },
                    { 3, true, 4, new DateTime(2025, 4, 23, 18, 30, 17, 6, DateTimeKind.Local).AddTicks(8946), "necesito cortar el pasto", null, "Marta", "Buenos Aires", "Busco Jardinero" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rating_EmployeeId",
                table: "Rating",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_EmployerId",
                table: "Jobs",
                column: "EmployerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Users_EmployerId",
                table: "Jobs",
                column: "EmployerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Postulation_Jobs_JobId",
                table: "Postulation",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Postulation_Users_EmployeeId",
                table: "Postulation",
                column: "EmployeeId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Users_EmployeeId",
                table: "Rating",
                column: "EmployeeId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Users_EmployerId",
                table: "Rating",
                column: "EmployerId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
