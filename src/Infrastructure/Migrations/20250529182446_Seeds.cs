using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Seeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Email", "Password", "PhoneNumber", "Province", "Role", "UserName" },
                values: new object[,]
                {
                    { 4, "Rosario", "marmax0504@gmail.com", "$2a$11$CfbSAv//7Sy7KlTfgVITHe9Hkm16.8ibd.UU8mxFDTlZBTLUhDWJW", "3496502453", "Santa Fe", "Client", "Maximo Martin" },
                    { 5, "La Plata", "joako.tanlon@gmail.com", "$2a$11$WSI7flznekce6WfzTv7fhOtypPO4JogIJ5HX2XPW80dyfBDIiLK/G", "3412122907", "Buenos Aires", "Client", "Joaquin Tanlongo" },
                    { 6, "Rosario", "marucomass@gmail.com", "$2a$11$v7o2qWdBz7tB63Z4Pe89CuUW3KFuIa5dD.PCVV5xIovGReECuFM1a", "3467637190", "Santa Fe", "Client", "Mario Massonnat" },
                    { 7, "Marcos Juarez", "frandepe7@gmail.com", "$2a$11$4kqg9yk4OgCcIq7fksQUKes5RZSv61Nu67srCImSbGpci8yRxPDoG", "3472582334", "Córdoba", "Client", "Francisco Depetrini" },
                    { 8, "Firmat", "palenafrancisco@gmail.com", "$2a$11$teJ9CDRzkVZKQByAgMKS5u2cwlVWnV7XkGAgrXhjY5Yyp3rUG8JpC", "3465664518", "Santa Fe", "Client", "Francisco Palena" },
                    { 9, "Bigand", "pedrogasparini99@gmail.com", "$2a$11$oguOFQoITRdDaB6sk5Gk/.pZ8K61IyhiILk9gX6GQ8k409fXH8uiy", "3464445164", "Santa Fe", "Client", "Pedro Gasparini" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Category", "City", "ClientId", "DayPublicationEnd", "DayPublicationStart", "Description", "PostulationSelectedId", "Province", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 6, "Rosario", 4, new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Necesito pintar un monoambiente en el centro", null, "Santa Fe", 0, "Pintar departamento" },
                    { 2, 2, "Rosario", 4, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instalación de 10 luces LED en cocina y living", null, "Santa Fe", 0, "Instalación de luces LED" },
                    { 3, 4, "La Plata", 5, new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patio de 100m2 con pasto alto, se necesita corte y limpieza", null, "Buenos Aires", 0, "Corte de pasto y desmalezado" },
                    { 4, 1, "Godoy Cruz", 6, new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hay una pérdida debajo del lavabo", null, "Mendoza", 0, "Reparar cañería del baño" },
                    { 5, 3, "Rosario", 6, new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Necesito ayuda para mudar muebles pesados", null, "Santa Fe", 0, "Mudanza de muebles" },
                    { 6, 4, "Marcos Juarez", 7, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jardín de 50m2 con césped crecido", null, "Córdoba", 0, "Corte de césped y limpieza del jardín" },
                    { 7, 9, "Firmat", 8, new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Limpieza profunda de casa de 3 ambientes", null, "Santa Fe", 0, "Limpieza de hogar" },
                    { 8, 8, "Bigand", 9, new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Necesito un desarrollador fullstack para una app de gestión", null, "Santa Fe", 0, "Programar aplicación web" }
                });

            migrationBuilder.InsertData(
                table: "Postulations",
                columns: new[] { "Id", "Budget", "ClientId", "JobDay", "JobId", "Status" },
                values: new object[,]
                {
                    { 1, 15000f, 6, new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, 14000f, 7, new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0 },
                    { 3, 20000f, 4, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 0 },
                    { 4, 18000f, 8, new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 5, 22000f, 9, new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 0 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ClientId", "Description", "JobId", "RatedByUserId", "RatedUserId", "Score" },
                values: new object[,]
                {
                    { 1, null, "muy amable y hasta me ofrecio facturas.", 1, 7, 4, 4 },
                    { 2, null, "tipazo, muy prolijo!", 1, 4, 7, 5 },
                    { 3, null, "estaba de mal humor y me trato bastante mal", 3, 4, 5, 1 },
                    { 4, null, "me dejo el patio hecho un desastre", 3, 5, 4, 1 },
                    { 5, null, "el baño estaba un poco sucio. buen trato!", 4, 9, 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "CategoryReport", "ClientId", "Created_At", "JobId" },
                values: new object[,]
                {
                    { 1, 3, 4, new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 2, 0, 5, new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 3, 3, 6, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 3);

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
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
