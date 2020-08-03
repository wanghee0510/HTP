using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_HTP.Migrations
{
    public partial class CreateTableHTP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentLists",
                columns: table => new
                {
                    StudentListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ShortDescription = table.Column<string>(nullable: false),
                    FullContent = table.Column<string>(nullable: false),
                    CoverImg = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentLists", x => x.StudentListId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentLists");
        }
    }
}
