using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Project.Migrations
{
    public partial class AddedNonProfitPictures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 9,
                column: "Path",
                value: "/images/NonPawFit-AdminDashboardDonors.jpg");

            migrationBuilder.InsertData(
                table: "PicturePaths",
                columns: new[] { "PictureID", "Path", "ProjectID" },
                values: new object[,]
                {
                    { 10, "/images/NonPawFit-AdminDashboardEmployees.jpg", 1 },
                    { 11, "/images/NonPawFit-AdminDashboardMembership.jpg", 1 },
                    { 12, "/images/NonPawFit-AdminDashboardEvents.jpg", 1 },
                    { 13, "/images/NonPawFit-AdminDashboardNews.jpg", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 1,
                columns: new[] { "About", "GithubLink" },
                values: new object[] { "<p>Non-Paw-Fit Animal Rescue is a web application developed in ASP.Net Core with the purpose of being able to manage a nonprofit&#39;s user accounts(employee and customer), donations, memberships, committees, event calendar, and also generate formatted reports.</p> <p>&nbsp;</p> <p>This project was created in collaboration with 4 other group members at Greenville Technical College. I primarily worked on the backend of the application however, I have touched nearly every corner of this project.</p>", "https://github.com/nicknewton100/NonProfitProject" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "PicturePaths",
                keyColumn: "PictureID",
                keyValue: 9,
                column: "Path",
                value: "/images/NonPawFit-AdminDashboardEvents.jpg");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 1,
                columns: new[] { "About", "GithubLink" },
                values: new object[] { "<p>Non-Paw-Fit Animal Rescue is a web application developed in ASP.Net Core with the purpose of being able to manage a nonprofit&#39;s user accounts(employee and customer), donations, memberships, committies, event calendar, and also generate formatted reports.</p> <p>&nbsp;</p> <p>This project was created in collaboration with 4 other group members at Greenville Technical College. I primarily worked on the backend of the application however, I have touched nearly every corner of this project.</p>", "https://github.com/thomasonbd/NonProfitProject" });
        }
    }
}
