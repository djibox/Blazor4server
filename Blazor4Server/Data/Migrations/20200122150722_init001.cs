using Microsoft.EntityFrameworkCore.Migrations;

namespace Blazor4Server.Data.Migrations
{
    public partial class init001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    Firstname = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(nullable: false),
                    School = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Firstname", "Lastname", "School" },
                values: new object[] { "261c8318-e9bc-42f2-b0f2-95c2bb3fb9a3", "Leger", "DJIBA", "CEMIS" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Firstname", "Lastname", "School" },
                values: new object[] { "181452be-5506-4246-8775-a70d134f349a", "Jean Linux", "DJIBA", "Havard" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Firstname", "Lastname", "School" },
                values: new object[] { "e8cf6db5-3c9f-4aea-b642-4a4e5d0826af", "Leger Junior", "DJIBA", "Teluq" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
