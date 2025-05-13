using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class createdNewTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_Users_ClientId",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_Users_SupportId",
                table: "Complaint");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rating",
                table: "Rating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Postulation",
                table: "Postulation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Complaint",
                table: "Complaint");

            migrationBuilder.RenameTable(
                name: "Rating",
                newName: "Ratings");

            migrationBuilder.RenameTable(
                name: "Postulation",
                newName: "Postulations");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "Complaint",
                newName: "Complaints");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_JobId",
                table: "Ratings",
                newName: "IX_Ratings_JobId");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_ClientId",
                table: "Ratings",
                newName: "IX_Ratings_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Postulation_JobId",
                table: "Postulations",
                newName: "IX_Postulations_JobId");

            migrationBuilder.RenameIndex(
                name: "IX_Postulation_ClientId",
                table: "Postulations",
                newName: "IX_Postulations_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Complaint_SupportId",
                table: "Complaints",
                newName: "IX_Complaints_SupportId");

            migrationBuilder.RenameIndex(
                name: "IX_Complaint_ClientId",
                table: "Complaints",
                newName: "IX_Complaints_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ratings",
                table: "Ratings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Postulations",
                table: "Postulations",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Complaints",
                table: "Complaints",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Complaints_Users_ClientId",
                table: "Complaints",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaints_Users_SupportId",
                table: "Complaints",
                column: "SupportId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Postulations_Jobs_JobId",
                table: "Postulations",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Postulations_Users_ClientId",
                table: "Postulations",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Jobs_JobId",
                table: "Ratings",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Users_ClientId",
                table: "Ratings",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Payments_PaymentId",
                table: "Users",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complaints_Users_ClientId",
                table: "Complaints");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaints_Users_SupportId",
                table: "Complaints");

            migrationBuilder.DropForeignKey(
                name: "FK_Postulations_Jobs_JobId",
                table: "Postulations");

            migrationBuilder.DropForeignKey(
                name: "FK_Postulations_Users_ClientId",
                table: "Postulations");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Jobs_JobId",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Users_ClientId",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Payments_PaymentId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ratings",
                table: "Ratings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Postulations",
                table: "Postulations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Complaints",
                table: "Complaints");

            migrationBuilder.RenameTable(
                name: "Ratings",
                newName: "Rating");

            migrationBuilder.RenameTable(
                name: "Postulations",
                newName: "Postulation");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payment");

            migrationBuilder.RenameTable(
                name: "Complaints",
                newName: "Complaint");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_JobId",
                table: "Rating",
                newName: "IX_Rating_JobId");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_ClientId",
                table: "Rating",
                newName: "IX_Rating_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Postulations_JobId",
                table: "Postulation",
                newName: "IX_Postulation_JobId");

            migrationBuilder.RenameIndex(
                name: "IX_Postulations_ClientId",
                table: "Postulation",
                newName: "IX_Postulation_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Complaints_SupportId",
                table: "Complaint",
                newName: "IX_Complaint_SupportId");

            migrationBuilder.RenameIndex(
                name: "IX_Complaints_ClientId",
                table: "Complaint",
                newName: "IX_Complaint_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rating",
                table: "Rating",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Postulation",
                table: "Postulation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Complaint",
                table: "Complaint",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_Users_ClientId",
                table: "Complaint",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_Users_SupportId",
                table: "Complaint",
                column: "SupportId",
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
    }
}
