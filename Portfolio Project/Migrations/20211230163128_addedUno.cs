using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Project.Migrations
{
    public partial class addedUno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 1,
                column: "Path",
                value: "/images/Nonpawfit.jpg");

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectID", "About", "GithubLink", "Name", "ShortDesc", "TechnicalSpecs", "WebLink" },
                values: new object[] { 2, "<p>Uno JavaFX is the game of Uno where you will face against an AI to see who will win. This game was created in collaboration with 2 other teammebers at greenville technical college using JavaFX. I mainly worked on the backend of the project creating all of the game logic and the AI however, some parts of the visuals I&nbsp;worked on as well.</p>", "", "Uno JavaFX", null, "<ul><li>Java</li><li>JavaFX</li><li>CSS</li><li>IntelliJ</li></ul>", "" });

            migrationBuilder.InsertData(
                table: "PicturePaths",
                columns: new[] { "PictureID", "IsThumbnail", "Path", "ProjectID" },
                values: new object[] { 2, true, "/images/Uno-JavaFX.jpg", 2 });

            migrationBuilder.InsertData(
                table: "Project_Tags",
                columns: new[] { "Project_TagsID", "ProjectID", "TagID" },
                values: new object[,]
                {
                    { 8, 2, 2 },
                    { 9, 2, 7 },
                    { 10, 2, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Project_Tags",
                keyColumn: "Project_TagsID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Project_Tags",
                keyColumn: "Project_TagsID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Project_Tags",
                keyColumn: "Project_TagsID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 1,
                column: "Path",
                value: "~/images/Nonpawfit.jpg");
        }
    }
}
