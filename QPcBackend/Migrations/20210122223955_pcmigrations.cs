using Microsoft.EntityFrameworkCore.Migrations;

namespace QPcBackend.Migrations
{
    public partial class pcmigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "PCPart",
                columns: table => new
                {
                    SKU = table.Column<int>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: false),
                    ProducName = table.Column<string>(nullable: false),
                    Price = table.Column<string>(nullable: false),
                    Warranty = table.Column<int>(nullable: false),
                    Category = table.Column<int>(nullable: false),
                    ImgUrl = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCPart", x => x.SKU);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "PCPart");
        }
    }
}
