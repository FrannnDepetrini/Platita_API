using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CommentAPpContx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Postulations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<int>(
                name: "PostulationSelectedId",
                table: "Jobs",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_PostulationSelectedId",
                table: "Jobs",
                column: "PostulationSelectedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Postulations_PostulationSelectedId",
                table: "Jobs",
                column: "PostulationSelectedId",
                principalTable: "Postulations",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Postulations_PostulationSelectedId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_PostulationSelectedId",
                table: "Jobs");

            migrationBuilder.AlterColumn<int>(
                name: "PostulationSelectedId",
                table: "Jobs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { 1, "Pagos digitales a través de MercadoPago. Rápido y seguro.", 0 },
                    { 2, "Transferencia bancaria directa a la cuenta indicada por el usuario.", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Email", "Password", "PaymentId", "PhoneNumber", "Province", "Role", "UserName" },
                values: new object[,]
                {
                    { 4, "Rosario", "marmax0504@gmail.com", "$2a$11$62/ktj3.pWYpPSxoTfIVceKpmBP8eEaynOd1tTR2dWtLBp0KlXE76", null, "3496502453", "Santa Fe", "Client", "Maximo Martin" },
                    { 5, "La Plata", "joako.tanlon@gmail.com", "$2a$11$OsXpT8tGJICtNJ9rfEGhReMfUz3Bwns8st/rcfH08fjkujH6HUOwa", null, "3412122907", "Buenos Aires", "Client", "Joaquin Tanlongo" },
                    { 6, "Rosario", "marucomass@gmail.com", "$2a$11$okz6lEDGJpQoVSEH2/8v8e9l4kv5YJXKXBXVlC/d429Hojg21jJlG", null, "3467637190", "Santa Fe", "Client", "Mario Massonnat" },
                    { 7, "Marcos Juarez", "frandepe7@gmail.com", "$2a$11$hx9mYrEhXpxjepo/oB9omO.nidHD5bW7bFHP3ab65gmm5UHkouvLi", null, "3472582334", "Córdoba", "Client", "Francisco Depetrini" },
                    { 8, "Firmat", "palenafrancisco@gmail.com", "$2a$11$7zFrfm79NSWLUKbqVCRdHe1ms3K5.54dU5sskhqAJMYzvK6KQY2JG", null, "3465664518", "Santa Fe", "Client", "Francisco Palena" },
                    { 9, "Bigand", "pedrogasparini99@gmail.com", "$2a$11$h7llnqtbrY9ugyt0uxO/r.RpWIDnxV52SJbKIx.UDFHyG/U4RFQ3a", null, "3464445164", "Santa Fe", "Client", "Pedro Gasparini" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Category", "City", "ClientId", "DayPublicationEnd", "DayPublicationStart", "Description", "PaymentId", "PostulationSelectedId", "Province", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 6, "Rosario", 4, new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Necesito pintar un monoambiente en el centro", 1, 0, "Santa Fe", 0, "Pintar departamento" },
                    { 2, 2, "Rosario", 4, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instalación de 10 luces LED en cocina y living", 1, 0, "Santa Fe", 0, "Instalación de luces LED" },
                    { 3, 4, "La Plata", 5, new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patio de 100m2 con pasto alto, se necesita corte y limpieza", 1, 0, "Buenos Aires", 0, "Corte de pasto y desmalezado" },
                    { 4, 1, "Godoy Cruz", 6, new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hay una pérdida debajo del lavabo", 1, 0, "Mendoza", 0, "Reparar cañería del baño" },
                    { 5, 3, "Rosario", 6, new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Necesito ayuda para mudar muebles pesados", 1, 0, "Santa Fe", 0, "Mudanza de muebles" },
                    { 6, 4, "Marcos Juarez", 7, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jardín de 50m2 con césped crecido", 1, 0, "Córdoba", 0, "Corte de césped y limpieza del jardín" },
                    { 7, 9, "Firmat", 8, new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Limpieza profunda de casa de 3 ambientes", 1, 0, "Santa Fe", 0, "Limpieza de hogar" },
                    { 8, 8, "Bigand", 9, new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Necesito un desarrollador fullstack para una app de gestión", 1, 0, "Santa Fe", 0, "Programar aplicación web" }
                });

            migrationBuilder.InsertData(
                table: "Postulations",
                columns: new[] { "Id", "Budget", "ClientId", "JobDay", "JobId", "Status" },
                values: new object[,]
                {
                    { 1, 15000f, 6, new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, 14000f, 7, new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0 },
                    { 3, 20000f, 4, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 4, 18000f, 8, new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 5, 22000f, 9, new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 0 }
                });
        }
    }
}
