using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactsAPI.Persistence.Migrations
{
    public partial class DataBaseSchemaUpdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contact_Email",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_PhoneNumber",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_Email_PhoneNumber",
                table: "Contact");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Contact",
                type: "VARCHAR(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contact",
                type: "VARCHAR(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Contact",
                type: "VARCHAR(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contact",
                type: "VARCHAR(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Contact",
                type: "VARCHAR(30)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_Email",
                table: "Contact",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_PhoneNumber",
                table: "Contact",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_Email_PhoneNumber",
                table: "Contact",
                columns: new[] { "Email", "PhoneNumber" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contact_Email",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_PhoneNumber",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_Email_PhoneNumber",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Contact");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Contact",
                type: "VARCHAR(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(30)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contact",
                type: "VARCHAR(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(30)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Contact",
                type: "VARCHAR(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(30)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contact",
                type: "VARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_Email",
                table: "Contact",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_PhoneNumber",
                table: "Contact",
                column: "PhoneNumber",
                unique: true,
                filter: "[PhoneNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_Email_PhoneNumber",
                table: "Contact",
                columns: new[] { "Email", "PhoneNumber" },
                unique: true,
                filter: "[Email] IS NOT NULL AND [PhoneNumber] IS NOT NULL");
        }
    }
}
