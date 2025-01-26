using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxFiler.DB.Migrations
{
    /// <inheritdoc />
    public partial class transactiontodocument : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DocumentId",
                table: "Transactions",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsIncomeTaxRelevant",
                table: "Transactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsOutgoing",
                table: "Transactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TaxMonth",
                table: "Transactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaxYear",
                table: "Transactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaxMonth",
                table: "Documents",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaxYear",
                table: "Documents",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_DocumentId",
                table: "Transactions",
                column: "DocumentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Documents_DocumentId",
                table: "Transactions",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Documents_DocumentId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_DocumentId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "DocumentId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "IsIncomeTaxRelevant",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "IsOutgoing",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "TaxMonth",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "TaxYear",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "TaxMonth",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "TaxYear",
                table: "Documents");
        }
    }
}
