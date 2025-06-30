using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class newSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                column: "City",
                value: "Marcos Juárez");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$sDcMmIAjmxU/m.t24cde0eLN5jcXaFl0l0nQ2meb8Ovj4ffx2P99u");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$gB6.JBRG3IjgLBe6jO2//evPHXVUCqjUxeIr8pFlKikvWMtBGM.Du");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$YLJGxq8CinjKOBUI2ZX2R.ZJrN2jUMhKNbAB4LK8qCbJMzaXx5322");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$tY.hViKZV8Mj9cnMI2F31.j7LL0cYNEEP7IwRqU.M4KyqESzt4oa2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$hRc08hY38yvJuUYkEy/JOufUCWgV2grSV7AyrrHZDdIswnFU15jJi");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$JqPDkLBEXzuITOWSFzhpjOIZFYVXmtFYFvSXX4emCeSGvnzryuwxy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Password" },
                values: new object[] { "Marcos Juárez", "$2a$11$G/suGWwv/N9ABAkS3X4zkO.HusRFGxo/JQqAICRKAI.nbgWYzpiX." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$hGNDN5kMkZIvl61rpZJ4u.W7eocqM9dNIOIAPvGQt/39RZFrYcAV6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$nSn1xuehu2TYMKKdzMa3VeGVtGGPKmI4OTmOr.qBGjuU4HBmTBocG");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6,
                column: "City",
                value: "Marcos Juarez");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$CB1ysl1/UPjCFvl/JXLP9OAVFp.dpgQzurRVmy2uLJA7B9uja4cr.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$uZG0mGxqmbdWyopG6SSGBu520fE4LSjqcylY2PkXYnVxweA9ILjT.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$.DcNPK7JJKJ4NXudgEov6eBQbSLan8RLvoAaBUwVMB/6v3UvZlJ8S");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$6CZ.Ukg31wBnlt2DH7mJAOgm4gqpN0Pi4hFhgODvnX7qGLKmL7CXW");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$NvBN5y7wuMfSna9lXDKbce/YcepMIo73z13pDjjZfesrQ4oXc6ak2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$vlou8FR1a8ltdsw/tKzQaOc7gNw.W5NpgMaOH//665hNGpnWy132S");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Password" },
                values: new object[] { "Marcos Juarez", "$2a$11$tXCGt1rvv33Iqt4k8Frp9uGFby06t6R6uPeBOGQOdeKfcONpSPtt6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$sygfr2s7kJ24f4cK7jSAYOVH539yr2WDup6EKU4MVM.SwQnsPJb16");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$VkzPEw/bv.ggfgv9OHrRben8/F7q1hdhSK9civxIW.9P3Itn5BPOe");
        }
    }
}
