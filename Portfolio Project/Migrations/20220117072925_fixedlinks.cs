using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Project.Migrations
{
    public partial class fixedlinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 1,
                column: "WebLink",
                value: "http://www.nonpawfit.net");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 3,
                column: "WebLink",
                value: "https://www.nicholasnewton.net/");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 1,
                column: "WebLink",
                value: "www.nonpawfit.net");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 3,
                column: "WebLink",
                value: "www.nicholasnewton.net");
        }
    }
}
