using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Project.Migrations
{
    public partial class thumbnailpicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsThumbnail",
                table: "PicturePaths",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "PicturePaths",
                columns: new[] { "PictureID", "IsThumbnail", "Path", "ProjectID" },
                values: new object[] { 1, true, "~/images/Nonpawfit.jpg", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "IsThumbnail",
                table: "PicturePaths");
        }
    }
}
