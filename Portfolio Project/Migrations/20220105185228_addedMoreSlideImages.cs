using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Project.Migrations
{
    public partial class addedMoreSlideImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PicturePaths",
                columns: new[] { "PictureID", "Path", "ProjectID" },
                values: new object[,]
                {
                    { 4, "/images/Uno-Game2.jpg", 2 },
                    { 5, "/images/Uno-Game3.jpg", 2 },
                    { 6, "/images/Uno-Game4.jpg", 2 },
                    { 7, "/images/Uno-Game5.jpg", 2 },
                    { 8, "/images/NonPawFit-AdminDashboard.jpg", 1 },
                    { 9, "/images/NonPawFit-AdminDashboardEvents.jpg", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 9);
        }
    }
}
