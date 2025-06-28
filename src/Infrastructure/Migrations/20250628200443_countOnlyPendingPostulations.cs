using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class countOnlyPendingPostulations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "Password",
                value: "$2a$11$tXCGt1rvv33Iqt4k8Frp9uGFby06t6R6uPeBOGQOdeKfcONpSPtt6");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$4N.f0ikpktdeWULqQ7OEpOkvutJScn9rYOa/6PpggiGla.FhXDKEG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$u9BOz7RwPUflw1GPa1AqEOKuhwnoTOuW017UBi/fma6L7G27WhpmK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$8jFwOMezmTxEn9qFnOaxue5khN0N5eicOrP1iF3XiPu0vHkTFcSDu");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$vXckzsaQdrVQl2tHP/oZi.0ZZEGEazNI.LNHfkM0y8JUHaDywSSUy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$jt7rpxQh5S8Pv/SfHpkV7OCMUixO2Mth779EY4wtjOOHA/ZiG/AFK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$gY8sb4q4nlKc39qeU2Do3ehxMRTNn/KrrXXpORruCtQYlvVCMAahm");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$wdiSFB0PvrukajeIChQKI.3hN/D73aBZUYddNcBpsF8pOR2puQ83y");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$2P3wZrjA/W/1KtPuPlM7vubduLHKcOXQqT5grftMVgcHjAQLAG4bS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$6Z3n3e5Xz4YBtQKHpHlclOYVtr4GKG4GGbHmZXfSPc68PORKEkSF.");
        }
    }
}
