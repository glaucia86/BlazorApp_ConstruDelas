using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp_CRUD.Server.Migrations
{
    public partial class WMCMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "userdetails",
                columns: table => new
                {
                    Userid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    address = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    phone_number = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    email_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("user_id", x => x.Userid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userdetails");
        }
    }
}
