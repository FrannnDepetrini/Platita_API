using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPostulationSelected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostulationSelectedId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostulationSelectedId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostulationSelectedId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$TANTL6iLnGDdw5RnKiQmk.G7MrexXh4fpA7r2dEO27hGpVdTI36Zi");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$l43eUoXysLdXWoGV3Y4RAO.6gpYwWr/8WXI4wkYrKMeCnihgs6Uvq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$4CPo9wDu1Otj5ZEhk0S.tuc/UBHj25dNvyzV6/TMfegApa.JPsaXO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$JDjmCUD0.4R7OwoUkfCpc.2Wq2q70Y4vx.6VGFC95YdBtWabaTjoy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$D6Qf2YJMqeZlTyreDOazjOLYsKvQB1uTiOqTbIQIUHLarTwX9IqgG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$nhZDJyXsArYeE/meDLgse.n6kNkIkspneF5L5t61UsFzM/KphLnti");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostulationSelectedId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostulationSelectedId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostulationSelectedId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$sK6ebe01CXcoAlX/qmUv8.w9cz7fZFWTxM1ZedqKdcw1fAVt5Wg3a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Password",
                value: "$2a$11$E9dodOoc0J/vf00AmgqNZePW8xcn14t9t1qomffZWbM4W6K8i92UC");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Password",
                value: "$2a$11$0NJTFAZNbAPsBCjH6wDqQe58XxVjSMgQ34WIEroEghNdf6QsPnUE6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Password",
                value: "$2a$11$blzCqabA0JXMQzu9OXZlxOwI5IWMY83J1SlXffuwbm1a1gyGpwf4K");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Password",
                value: "$2a$11$UwFLgycgGlB72eHz8/UKzebflQSUEqAFrkaYzjW2.N64IbqiQ/3be");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Password",
                value: "$2a$11$lJ8PpYJtFDOnvfh13klx9.WN8LU7ll5YCJ6p4ZlZWp0PYNU2.8IyO");
        }
    }
}
