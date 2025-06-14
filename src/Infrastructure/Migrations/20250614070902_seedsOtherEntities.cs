using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedsOtherEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OneTimeTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Token = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Expiration = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsUsed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OneTimeTokens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    Province = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Complaints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Complaints_Users_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<int>(type: "integer", nullable: false),
                    PostulationSelectedId = table.Column<int>(type: "integer", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: false),
                    DayPublicationStart = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DayPublicationEnd = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<int>(type: "integer", nullable: false),
                    Province = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_Users_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Postulations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<int>(type: "integer", nullable: false),
                    JobId = table.Column<int>(type: "integer", nullable: false),
                    Budget = table.Column<float>(type: "real", nullable: false),
                    JobDay = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postulations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Postulations_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Postulations_Users_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RatedByUserId = table.Column<int>(type: "integer", nullable: true),
                    RatedUserId = table.Column<int>(type: "integer", nullable: false),
                    Score = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    JobId = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Users_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created_At = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CategoryReport = table.Column<int>(type: "integer", nullable: false),
                    JobId = table.Column<int>(type: "integer", nullable: false),
                    ClientId = table.Column<int>(type: "integer", nullable: false)
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "PhoneNumber", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, "sysadmin@gmail.com", "$2a$11$8lU1szEStHsHLQK1sN4ZKu/YKwY8FpMOmkIxazF4aVEWTBZwXuTVi", "341001122", 0, "platita" },
                    { 2, "moderator@gmail.com", "$2a$11$AGzQLZ6oj5tmayPVcCcLEedahAYJiZLWdB4NeN7RU2P2F6.29LHUO", "341987654321", 1, "moderator1" },
                    { 3, "support@gmail.com", "$2a$11$LuktQJRT5b/zekFoOrkM1uiECD3nRbIZZz4q1IZ8lVJFYcx0AhkEy", "341112233", 3, "support1" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Email", "Password", "PhoneNumber", "Province", "Role", "UserName" },
                values: new object[,]
                {
                    { 4, "Rosario", "marmax0504@gmail.com", "$2a$11$Kr/WsIOFdqmva91Ze1exOuk3C27KpiKUjXrBdrdKLQU5.1sezz3a2", "3496502453", "Santa Fe", 2, "Maximo Martin" },
                    { 5, "La Plata", "joako.tanlon@gmail.com", "$2a$11$rrxmrNZYCccdWObKu/GOZuOrrySBlYPEMiLvXpEs5n2ipG9.KGIwa", "3412122907", "Buenos Aires", 2, "Joaquin Tanlongo" },
                    { 6, "Rosario", "marucomass@gmail.com", "$2a$11$U.nbSNyIHgEoASosg2N9/OrmdqghH1Q.79Ha3phjV/3SR78kP1Weq", "3467637190", "Santa Fe", 2, "Mario Massonnat" },
                    { 7, "Marcos Juarez", "frandepe7@gmail.com", "$2a$11$7zTfXvOakzJ.yIVvWKSBz.BzgbbiJsX7WlMRNGtoHuMeVa7fyBt9O", "3472582334", "Córdoba", 2, "Francisco Depetrini" },
                    { 8, "Firmat", "palenafrancisco@gmail.com", "$2a$11$4Y7rjf1zzA7ubI948sAlMeFkyKzQKlP4u7ZWcrKq/715P.29E7pQy", "3465664518", "Santa Fe", 2, "Francisco Palena" },
                    { 9, "Bigand", "pedrogasparini99@gmail.com", "$2a$11$bQiNDxIEum81JhGbaILCr.D2zx./xl0lZR6IQFUin.bwO7JimG6rm", "3464445164", "Santa Fe", 2, "Pedro Gasparini" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Category", "City", "ClientId", "DayPublicationEnd", "DayPublicationStart", "Description", "PostulationSelectedId", "Province", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 6, "Rosario", 4, new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Necesito pintar un monoambiente en el centro", null, "Santa Fe", 0, "Pintar departamento" },
                    { 2, 2, "Rosario", 4, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Instalación de 10 luces LED en cocina y living", null, "Santa Fe", 0, "Instalación de luces LED" },
                    { 3, 4, "La Plata", 5, new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Patio de 100m2 con pasto alto, se necesita corte y limpieza", null, "Buenos Aires", 0, "Corte de pasto y desmalezado" },
                    { 4, 1, "Godoy Cruz", 6, new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Hay una pérdida debajo del lavabo", null, "Mendoza", 0, "Reparar cañería del baño" },
                    { 5, 3, "Rosario", 6, new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Necesito ayuda para mudar muebles pesados", null, "Santa Fe", 0, "Mudanza de muebles" },
                    { 6, 4, "Marcos Juarez", 7, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Jardín de 50m2 con césped crecido", null, "Córdoba", 0, "Corte de césped y limpieza del jardín" },
                    { 7, 9, "Firmat", 8, new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Limpieza profunda de casa de 3 ambientes", null, "Santa Fe", 0, "Limpieza de hogar" },
                    { 8, 8, "Bigand", 9, new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Necesito un desarrollador fullstack para una app de gestión", null, "Santa Fe", 0, "Programar aplicación web" }
                });

            migrationBuilder.InsertData(
                table: "Postulations",
                columns: new[] { "Id", "Budget", "ClientId", "JobDay", "JobId", "Status" },
                values: new object[,]
                {
                    { 1, 15000f, 6, new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Utc), 1, 1 },
                    { 2, 14000f, 7, new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Utc), 1, 0 },
                    { 3, 20000f, 4, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Utc), 3, 0 },
                    { 4, 18000f, 8, new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc), 3, 2 },
                    { 5, 22000f, 9, new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Utc), 4, 0 }
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
                    { 1, 3, 4, new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Utc), 8 },
                    { 2, 0, 5, new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Utc), 8 },
                    { 3, 3, 6, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc), 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_ClientId",
                table: "Complaints",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_ClientId",
                table: "Jobs",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_PostulationSelectedId",
                table: "Jobs",
                column: "PostulationSelectedId");

            migrationBuilder.CreateIndex(
                name: "IX_Postulations_ClientId",
                table: "Postulations",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Postulations_JobId",
                table: "Postulations",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ClientId",
                table: "Ratings",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_JobId",
                table: "Ratings",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ClientId",
                table: "Reports",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_JobId",
                table: "Reports",
                column: "JobId");

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
                name: "FK_Jobs_Users_ClientId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Postulations_Users_ClientId",
                table: "Postulations");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Postulations_PostulationSelectedId",
                table: "Jobs");

            migrationBuilder.DropTable(
                name: "Complaints");

            migrationBuilder.DropTable(
                name: "OneTimeTokens");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Postulations");

            migrationBuilder.DropTable(
                name: "Jobs");
        }
    }
}
