using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_HTP.Migrations
{
    public partial class CreateTableHTP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoginUsers",
                columns: table => new
                {
                    LoginID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Account = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    NameUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginUsers", x => x.LoginID);
                });

            migrationBuilder.CreateTable(
                name: "StudentLists",
                columns: table => new
                {
                    StudentListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ShortDescription = table.Column<string>(nullable: false),
                    FullContent = table.Column<string>(nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentLists", x => x.StudentListId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginUsers");

            migrationBuilder.DropTable(
                name: "StudentLists");
        }
    }
}
