using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewSeedsClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Jobs",
                newName: "DayPublicationStart");

            migrationBuilder.AddColumn<DateTime>(
                name: "DayPublicationEnd",
                table: "Jobs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Jobs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "UserName" },
                values: new object[] { "$2a$11$7dh6BoUfkk7T5ODGeD6YoepecYLDq1.JVfS/MKNIv8ScDN3m0JqbS", "Maximo Martin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Email", "Password", "PhoneNumber", "Province", "UserName" },
                values: new object[] { "Rosario", "marucomass@gmail.com", "$2a$11$5qAQAVoIAQtIj0PGrDloY.X2cdoVnbJf3e8UJ/usaoNC5F4gZWbyu", "3467637190", "Santa Fe", "Mario Massonnat" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Email", "Password", "PhoneNumber", "Province", "UserName" },
                values: new object[] { "Marcos Juarez", "frandepe7@gmail.com", "$2a$11$Ez8SWNSOiygBI/Uc4yVqZ.wROLY7omwgtQcteCnMBC05Fg4ih16P2", "3472582334", "Córdoba", "Francisco Depetrini" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Email", "Password", "PaymentId", "PhoneNumber", "Province", "Role", "UserName" },
                values: new object[,]
                {
                    { 5, "La Plata", "joako.tanlon@gmail.com", "$2a$11$WlniJYkWorZLE9abEmR42uU56bh7R7t7ySVqh1p.hce.XS2MpE/1S", null, "3412122907", "Buenos Aires", "Client", "Joaquin Tanlongo" },
                    { 8, "Firmat", "palenafrancisco@gmail.com", "$2a$11$qd2LGtVE.h2gQplpHVAsPO5VkA6LuGGosoXTGH1m6SNRslBb6I9Fq", null, "3465664518", "Santa Fe", "Client", "Francisco Palena" },
                    { 9, "Bigand", "pedrogasparini99@gmail.com", "$2a$11$aYJanBwl7ClWRK6tSDv1veatNwdUJoSxE6thdO71g2.OX2mgYdplC", null, "3464445164", "Santa Fe", "Client", "Pedro Gasparini" }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Payments_PaymentId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_PaymentId",
                table: "Jobs");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "DayPublicationEnd",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "DayPublicationStart",
                table: "Jobs",
                newName: "DateTime");

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Jobs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "UserName" },
                values: new object[] { "$2a$11$RqjscQe2iJO0X6Jc/PLFSupjVS.t/LFjX/egxB1yHVvH/FUlQNqe6", "Maximo" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Email", "Password", "PhoneNumber", "Province", "UserName" },
                values: new object[] { "La Plata", "joako.tanlon@gmail.com", "$2a$11$ghM5dfEZ9mVLB1P/Mrw98OP2D/66ynalSKXliHQplGMIMfi7cT4k2", "3412122907", "Buenos Aires", "Joaquin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Email", "Password", "PhoneNumber", "Province", "UserName" },
                values: new object[] { "Rosario", "marucomass@gmail.com", "$2a$11$s.ypZhXO41KsgHTkDgfVlufLht1nnKAy6GpSemdywSH9fjwIz0aWi", "3467637190", "Santa Fe", "Mario" });
        }
    }
}
