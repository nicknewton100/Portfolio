using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Project.Migrations
{
    public partial class AddedlinksandPortfolio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 1,
                columns: new[] { "TechnicalSpecs", "WebLink" },
                values: new object[] { "<ul><li>ASP.Net Core v3.0</li><li>C#</li><li>Entity Framework Core</li><li>MSSQL</li><li>HTML/CSS</li><li>Javascript</li><li>Visual Studio</li><li>Azure Portal</li><li>Github</li><li>Sourcetree</li><li>Fast Report</li></ul>", "www.nonpawfit.net" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 2,
                column: "GithubLink",
                value: "https://github.com/nicknewton100/Uno-JavaFX");

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectID", "About", "GithubLink", "Name", "ShortDesc", "TechnicalSpecs", "ThumbnailPath", "WebLink" },
                values: new object[] { 3, "<p>Nicholasnewton.net is a personal portfolio project that is used to display my best work as well as introduce me to whoever comes across the site.</p>", "https://github.com/nicknewton100/Portfolio", "Portfolio", "<p>nichoasnewton.net is a personal portfolio website used to showscase my skills/projects</p>", "<ul><li>ASP.Net Core v3.1</li><li>C#</li><li>Entity Framework Core</li><li>MSSQL</li><li>HTML/CSS</li><li>Javascript</li><li>Visual Studio</li><li>Github</li><li>Sourcetree</li></ul>", "/images/PortfolioHome.jpg", "www.nicholasnewton.net" });

            migrationBuilder.InsertData(
                table: "PicturePaths",
                columns: new[] { "PictureID", "Path", "ProjectID" },
                values: new object[,]
                {
                    { 16, "/images/PortfolioHome.jpg", 3 },
                    { 17, "/images/PortfolioProjects.jpg", 3 },
                    { 18, "/images/PortfolioProjectsDetails.jpg", 3 },
                    { 19, "/images/PortfolioContact.jpg", 3 }
                });

            migrationBuilder.InsertData(
                table: "Project_Tags",
                columns: new[] { "Project_TagsID", "ProjectID", "TagID" },
                values: new object[,]
                {
                    { 11, 3, 1 },
                    { 12, 3, 2 },
                    { 13, 3, 3 },
                    { 14, 3, 4 },
                    { 15, 3, 5 },
                    { 16, 3, 6 },
                    { 17, 3, 11 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Project_Tags",
                keyColumn: "Project_TagsID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Project_Tags",
                keyColumn: "Project_TagsID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Project_Tags",
                keyColumn: "Project_TagsID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Project_Tags",
                keyColumn: "Project_TagsID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Project_Tags",
                keyColumn: "Project_TagsID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Project_Tags",
                keyColumn: "Project_TagsID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Project_Tags",
                keyColumn: "Project_TagsID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 1,
                columns: new[] { "TechnicalSpecs", "WebLink" },
                values: new object[] { "<ul><li>ASP.Net Core v3.0</li><li>C#</li><li>Entity Framework Core</li><li>MSSQL</li><li>HTML/CSS</li><li>Github</li><li>Sourcetree</li><li>Azure Portal</li><li>Visual Studio</li><li>Javascript</li><li>Fast Report</li></ul>", "" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 2,
                column: "GithubLink",
                value: "");
        }
    }
}
