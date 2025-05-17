using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewSeeds_Payment_Jobs_Postulation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Category", "City", "ClientId", "DayPublicationEnd", "DayPublicationStart", "Description", "PaymentId", "PostulationSelected", "Province", "Status", "Title" },
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
                columns: new[] { "Id", "Budget", "ClientId", "JobId", "Status" },
                values: new object[,]
                {
                    { 1, 15000f, 6, 1, 1 },
                    { 2, 14000f, 7, 1, 0 },
                    { 3, 20000f, 4, 2, 1 },
                    { 4, 18000f, 8, 3, 2 },
                    { 5, 22000f, 9, 4, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$7dh6BoUfkk7T5ODGeD6YoepecYLDq1.JVfS/MKNIv8ScDN3m0JqbS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$WlniJYkWorZLE9abEmR42uU56bh7R7t7ySVqh1p.hce.XS2MpE/1S");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$5qAQAVoIAQtIj0PGrDloY.X2cdoVnbJf3e8UJ/usaoNC5F4gZWbyu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$Ez8SWNSOiygBI/Uc4yVqZ.wROLY7omwgtQcteCnMBC05Fg4ih16P2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$qd2LGtVE.h2gQplpHVAsPO5VkA6LuGGosoXTGH1m6SNRslBb6I9Fq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$aYJanBwl7ClWRK6tSDv1veatNwdUJoSxE6thdO71g2.OX2mgYdplC");
        }
    }
}
