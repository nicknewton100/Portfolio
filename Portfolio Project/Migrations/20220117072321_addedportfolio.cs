using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Project.Migrations
{
    public partial class addedportfolio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 3,
                column: "ThumbnailPath",
                value: "/images/PortfolioHomeThumbnail.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 3,
                column: "ThumbnailPath",
                value: "/images/PortfolioHome.jpg");
        }
    }
}
