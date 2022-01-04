using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Project.Migrations
{
    public partial class firstproject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectID", "About", "GithubLink", "Name", "ShortDesc", "TechnicalSpecs", "WebLink" },
                values: new object[] { 1, "<p>Non-Paw-Fit Animal Rescue is a web application developed in ASP.Net Core with the purpose of being able to manage a nonprofit&#39;s user accounts(employee and customer), donations, memberships, committies, event calendar, and also generate formatted reports.</p> <p>&nbsp;</p> <p>This project was created in collaboration with 4 other group members at Greenville Technical College. I primarily worked on the backend of the application however, I have touched nearly every corner of this project.</p>", "https://github.com/thomasonbd/NonProfitProject", "Non-Paw-Fit Animal Rescue", null, "<ul><li>ASP.Net Core v3.0</li><li>C#</li><li>Entity Framework Core</li><li>MSSQL</li><li>HTML/CSS</li><li>Github</li><li>Sourcetree</li><li>Azure Portal</li><li>Visual Studio</li><li>Javascript</li><li>Fast Report</li></ul>", "" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagID", "TagName" },
                values: new object[,]
                {
                    { 1, "HTML" },
                    { 2, "CSS" },
                    { 3, "Javascript" },
                    { 4, "C#" },
                    { 5, "ASP.Net Core" },
                    { 6, "MSSQL" },
                    { 7, "Java" },
                    { 8, "JavaFX" },
                    { 9, "Python" },
                    { 10, "C++" },
                    { 11, "Github" }
                });

            migrationBuilder.InsertData(
                table: "Project_Tags",
                columns: new[] { "Project_TagsID", "ProjectID", "TagID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 1, 6 },
                    { 7, 1, 11 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Project_Tags",
                keyColumn: "Project_TagsID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project_Tags",
                keyColumn: "Project_TagsID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Project_Tags",
                keyColumn: "Project_TagsID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Project_Tags",
                keyColumn: "Project_TagsID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Project_Tags",
                keyColumn: "Project_TagsID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Project_Tags",
                keyColumn: "Project_TagsID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Project_Tags",
                keyColumn: "Project_TagsID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagID",
                keyValue: 11);
        }
    }
}
