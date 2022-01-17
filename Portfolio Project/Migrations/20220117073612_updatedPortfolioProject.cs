using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Project.Migrations
{
    public partial class updatedPortfolioProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 3,
                columns: new[] { "About", "ShortDesc" },
                values: new object[] { "<p>Nicholasnewton.net is a personal portfolio project developed in ASP.NET Core that is used to showcase my skills/projects associated with programming as well as give information about myself.</p>", "<p>Nicholasnewton.net is a personal portfolio website used to showcase my skills/projects</p>" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 3,
                columns: new[] { "About", "ShortDesc" },
                values: new object[] { "<p>Nicholasnewton.net is a personal portfolio project that is used to display my best work as well as introduce me to whoever comes across the site.</p>", "<p>Nicholasnewton.net is a personal portfolio website used to showscase my skills/projects</p>" });
        }
    }
}
