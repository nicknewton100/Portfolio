using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Project.Migrations
{
    public partial class changedPictures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsThumbnail",
                table: "PicturePaths");

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailPath",
                table: "Projects",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 2,
                column: "Path",
                value: "/images/Uno-Slides.jpg");

            migrationBuilder.InsertData(
                table: "PicturePaths",
                columns: new[] { "PictureID", "Path", "ProjectID" },
                values: new object[] { 3, "/images/Uno-Game1.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 1,
                column: "ThumbnailPath",
                value: "/images/Nonpawfit.jpg");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 2,
                column: "ThumbnailPath",
                value: "/images/Uno-JavaFX.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ThumbnailPath",
                table: "Projects");

            migrationBuilder.AddColumn<bool>(
                name: "IsThumbnail",
                table: "PicturePaths",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 1,
                column: "IsThumbnail",
                value: true);

            migrationBuilder.UpdateData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 2,
                columns: new[] { "IsThumbnail", "Path" },
                values: new object[] { true, "/images/Uno-JavaFX.jpg" });
        }
    }
}
