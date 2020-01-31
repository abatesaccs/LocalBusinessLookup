using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusinessLookup.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    BusinessId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.BusinessId);
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Name", "PhoneNumber", "Website" },
                values: new object[] { 1, "123 N Street St", "Dave's Music", "7", "Example.com" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Name", "PhoneNumber", "Website" },
                values: new object[] { 2, "456 N Way Rd", "John's Sounds", "867-5309", "Example.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Businesses");
        }
    }
}
