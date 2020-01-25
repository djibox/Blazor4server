using Microsoft.EntityFrameworkCore.Migrations;

namespace Blazor4Server.Data.Migrations
{
    public partial class migrationTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: "181452be-5506-4246-8775-a70d134f349a");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: "261c8318-e9bc-42f2-b0f2-95c2bb3fb9a3");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: "e8cf6db5-3c9f-4aea-b642-4a4e5d0826af");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Firstname", "Lastname", "School" },
                values: new object[] { "a5e8e884-a30f-488c-b14c-aa90d9f7a9af", "Leger", "DJIBA", "CEMIS" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Firstname", "Lastname", "School" },
                values: new object[] { "532c2942-959a-4b91-86d2-b2170948795e", "Jean Linux", "DJIBA", "Havard" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Firstname", "Lastname", "School" },
                values: new object[] { "98ea410b-d3f3-4136-b75b-5b91a0a91ddd", "Leger Junior", "DJIBA", "Teluq" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: "532c2942-959a-4b91-86d2-b2170948795e");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: "98ea410b-d3f3-4136-b75b-5b91a0a91ddd");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: "a5e8e884-a30f-488c-b14c-aa90d9f7a9af");

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
    }
}
