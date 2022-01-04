using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Project.Migrations
{
    public partial class addedShortDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 1,
                column: "ShortDesc",
                value: "<p>Non-Paw-Fit Animal Rescue is a database management website with logins, donations, users, etc.</p>");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 2,
                column: "ShortDesc",
                value: "<p>Uno JavaFX is an Uno game where you face against an AI opponent.</p>");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 1,
                column: "ShortDesc",
                value: null);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 2,
                column: "ShortDesc",
                value: null);
        }
    }
}
