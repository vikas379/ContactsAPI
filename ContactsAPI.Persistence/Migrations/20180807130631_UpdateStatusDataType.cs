using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactsAPI.Persistence.Migrations
{
    public partial class UpdateStatusDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Contact",
                type: "VARCHAR(10)",
                nullable: false,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Contact",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(10)");
        }
    }
}
