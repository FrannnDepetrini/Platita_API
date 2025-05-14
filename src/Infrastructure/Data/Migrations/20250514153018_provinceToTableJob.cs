using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class provinceToTableJob : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$RqjscQe2iJO0X6Jc/PLFSupjVS.t/LFjX/egxB1yHVvH/FUlQNqe6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$ghM5dfEZ9mVLB1P/Mrw98OP2D/66ynalSKXliHQplGMIMfi7cT4k2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$s.ypZhXO41KsgHTkDgfVlufLht1nnKAy6GpSemdywSH9fjwIz0aWi");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$v4nO3utFdRzhBn/celeWI.AM62XtfQoPEhHl4xdBmdPMANbF3/MnO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$0J0q1qnCrOJsMn3mS3nQy.mdRiUbe5rAz0ZtkjPI2qgvuXmQugSkG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$dl2U0Xyg/Nix.CacXSHD.upmcrwFdeH.rC7QRyLwYVZCoWPl4rKIi");
        }
    }
}
