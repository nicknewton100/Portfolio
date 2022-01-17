using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Project.Migrations
{
    public partial class fixedspellingerrors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 3,
                column: "ShortDesc",
                value: "<p>Nicholasnewton.net is a personal portfolio website used to showscase my skills/projects</p>");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 3,
                column: "ShortDesc",
                value: "<p>nichoasnewton.net is a personal portfolio website used to showscase my skills/projects</p>");
        }
    }
}
