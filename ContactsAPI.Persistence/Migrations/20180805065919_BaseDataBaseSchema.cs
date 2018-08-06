using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactsAPI.Persistence.Migrations
{
    public partial class BaseDataBaseSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    CreatorRID = table.Column<int>(nullable: false),
                    ModifierRID = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    LastName = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    Email = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");
        }
    }
}
