using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Project.Migrations
{
    public partial class AddedNonProfitPicturesagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PicturePaths",
                columns: new[] { "PictureID", "Path", "ProjectID" },
                values: new object[] { 14, "/images/NonPawFit-AdminDashboardDonationCheckout.jpg", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 14);
        }
    }
}
