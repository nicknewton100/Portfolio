using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio_Project.Migrations
{
    public partial class InitialMigrationAgainToFixErrors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThumbnailPath = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ShortDesc = table.Column<string>(nullable: true),
                    About = table.Column<string>(nullable: true),
                    TechnicalSpecs = table.Column<string>(nullable: true),
                    GithubLink = table.Column<string>(nullable: true),
                    WebLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagID);
                });

            migrationBuilder.CreateTable(
                name: "PicturePaths",
                columns: table => new
                {
                    PictureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(nullable: false),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PicturePaths", x => x.PictureID);
                    table.ForeignKey(
                        name: "FK_PicturePaths_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Project_Tags",
                columns: table => new
                {
                    Project_TagsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(nullable: false),
                    TagID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project_Tags", x => x.Project_TagsID);
                    table.ForeignKey(
                        name: "FK_Project_Tags_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Project_Tags_Tags_TagID",
                        column: x => x.TagID,
                        principalTable: "Tags",
                        principalColumn: "TagID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectID", "About", "GithubLink", "Name", "ShortDesc", "TechnicalSpecs", "ThumbnailPath", "WebLink" },
                values: new object[,]
                {
                    { 1, "<p>Non-Paw-Fit Animal Rescue is a web application developed in ASP.Net Core with the purpose of being able to manage a nonprofit&#39;s user accounts(employee and customer), donations, memberships, committies, event calendar, and also generate formatted reports.</p> <p>&nbsp;</p> <p>This project was created in collaboration with 4 other group members at Greenville Technical College. I primarily worked on the backend of the application however, I have touched nearly every corner of this project.</p>", "https://github.com/thomasonbd/NonProfitProject", "Non-Paw-Fit Animal Rescue", "<p>Non-Paw-Fit Animal Rescue is a database management website with logins, donations, users, etc.</p>", "<ul><li>ASP.Net Core v3.0</li><li>C#</li><li>Entity Framework Core</li><li>MSSQL</li><li>HTML/CSS</li><li>Github</li><li>Sourcetree</li><li>Azure Portal</li><li>Visual Studio</li><li>Javascript</li><li>Fast Report</li></ul>", "/images/Nonpawfit.jpg", "" },
                    { 2, "<p>Uno JavaFX is the game of Uno where you will face against an AI to see who will win. This game was created in collaboration with 2 other teammebers at greenville technical college using JavaFX. I mainly worked on the backend of the project creating all of the game logic and the AI however, some parts of the visuals I&nbsp;worked on as well.</p>", "", "Uno JavaFX", "<p>Uno JavaFX is an Uno game where you face against an AI opponent.</p>", "<ul><li>Java</li><li>JavaFX</li><li>CSS</li><li>IntelliJ</li></ul>", "/images/Uno-JavaFX.jpg", "" }
                });

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
                table: "PicturePaths",
                columns: new[] { "PictureID", "Path", "ProjectID" },
                values: new object[,]
                {
                    { 1, "/images/Nonpawfit.jpg", 1 },
                    { 8, "/images/NonPawFit-AdminDashboard.jpg", 1 },
                    { 9, "/images/NonPawFit-AdminDashboardEvents.jpg", 1 },
                    { 2, "/images/Uno-Slides.jpg", 2 },
                    { 3, "/images/Uno-Game1.jpg", 2 },
                    { 4, "/images/Uno-Game2.jpg", 2 },
                    { 5, "/images/Uno-Game3.jpg", 2 },
                    { 6, "/images/Uno-Game4.jpg", 2 },
                    { 7, "/images/Uno-Game5.jpg", 2 }
                });

            migrationBuilder.InsertData(
                table: "Project_Tags",
                columns: new[] { "Project_TagsID", "ProjectID", "TagID" },
                values: new object[,]
                {
                    { 9, 2, 7 },
                    { 6, 1, 6 },
                    { 5, 1, 5 },
                    { 4, 1, 4 },
                    { 1, 1, 1 },
                    { 8, 2, 2 },
                    { 2, 1, 2 },
                    { 10, 2, 8 },
                    { 3, 1, 3 },
                    { 7, 1, 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PicturePaths_ProjectID",
                table: "PicturePaths",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Tags_ProjectID",
                table: "Project_Tags",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Tags_TagID",
                table: "Project_Tags",
                column: "TagID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PicturePaths");

            migrationBuilder.DropTable(
                name: "Project_Tags");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
