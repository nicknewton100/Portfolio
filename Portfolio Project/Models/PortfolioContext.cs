using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Portfolio_Project.Models
{
    public class PortfolioContext : DbContext
    {
        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options) { }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<PicturePaths> PicturePaths { get; set; }
        public DbSet<Project_Tags> Project_Tags { get; set; }
        public DbSet<Tags> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Tags>().HasData(
                new Tags
                {
                    TagID = 1,
                    TagName = "HTML"
                },
                new Tags
                {
                    TagID = 2,
                    TagName = "CSS"
                },
                new Tags
                {
                    TagID = 3,
                    TagName = "Javascript"
                },
                new Tags
                {
                    TagID = 4,
                    TagName = "C#"
                },
                new Tags
                {
                    TagID = 5,
                    TagName = "ASP.Net Core"
                },
                new Tags
                {
                    TagID = 6,
                    TagName = "MSSQL"
                },
                new Tags
                {
                    TagID = 7,
                    TagName = "Java"
                },
                new Tags
                {
                    TagID = 8,
                    TagName = "JavaFX"
                },
                new Tags
                {
                    TagID = 9,
                    TagName = "Python"
                },
                new Tags
                {
                    TagID = 10,
                    TagName = "C++"
                },
                new Tags
                {
                    TagID = 11,
                    TagName = "Github"
                }
                );
            builder.Entity<Projects>().HasData(
                new Projects
                {
                    ProjectID = 1,
                    ThumbnailPath = "/images/Nonpawfit.jpg",
                    Name = "Non-Paw-Fit Animal Rescue",
                    ShortDesc = "<p>Non-Paw-Fit Animal Rescue is a database management website with logins, donations, users, etc.</p>",
                    About = "<p>Non-Paw-Fit Animal Rescue is a web application developed in ASP.Net Core with the purpose of being able to manage a nonprofit&#39;s user accounts(employee and customer), donations, memberships, committies, event calendar, and also generate formatted reports.</p> <p>&nbsp;</p> <p>This project was created in collaboration with 4 other group members at Greenville Technical College. I primarily worked on the backend of the application however, I have touched nearly every corner of this project.</p>",
                    TechnicalSpecs = "<ul><li>ASP.Net Core v3.0</li><li>C#</li><li>Entity Framework Core</li><li>MSSQL</li><li>HTML/CSS</li><li>Github</li><li>Sourcetree</li><li>Azure Portal</li><li>Visual Studio</li><li>Javascript</li><li>Fast Report</li></ul>",
                    GithubLink = "https://github.com/thomasonbd/NonProfitProject",
                    WebLink = ""
                },
                new Projects
                {
                    ProjectID = 2,
                    ThumbnailPath = "/images/Uno-JavaFX.jpg",
                    Name = "Uno JavaFX",
                    ShortDesc = "<p>Uno JavaFX is an Uno game where you face against an AI opponent.</p>",
                    About = "<p>Uno JavaFX is the game of Uno where you will face against an AI to see who will win. This game was created in collaboration with 2 other teammebers at greenville technical college using JavaFX. I mainly worked on the backend of the project creating all of the game logic and the AI however, some parts of the visuals I&nbsp;worked on as well.</p>",
                    TechnicalSpecs = "<ul><li>Java</li><li>JavaFX</li><li>CSS</li><li>IntelliJ</li></ul>",
                    GithubLink = "",
                    WebLink = ""
                }
                );
            builder.Entity<Project_Tags>().HasData(
                new Project_Tags
                {
                    Project_TagsID = 1,
                    ProjectID = 1,
                    TagID = 1
                },
                new Project_Tags
                {
                    Project_TagsID = 2,
                    ProjectID = 1,
                    TagID = 2
                },
                new Project_Tags
                {
                    Project_TagsID = 3,
                    ProjectID = 1,
                    TagID = 3
                },
                new Project_Tags
                {
                    Project_TagsID = 4,
                    ProjectID = 1,
                    TagID = 4
                },
                new Project_Tags
                {
                    Project_TagsID = 5,
                    ProjectID = 1,
                    TagID = 5
                },
                new Project_Tags
                {
                    Project_TagsID = 6,
                    ProjectID = 1,
                    TagID = 6
                },
                new Project_Tags
                {
                    Project_TagsID = 7,
                    ProjectID = 1,
                    TagID = 11
                },
                new Project_Tags
                {
                    Project_TagsID = 8,
                    ProjectID = 2,
                    TagID = 2
                },
                new Project_Tags
                {
                    Project_TagsID = 9,
                    ProjectID = 2,
                    TagID = 7
                },
                new Project_Tags
                {
                    Project_TagsID = 10,
                    ProjectID = 2,
                    TagID = 8
                }
                );
            builder.Entity<PicturePaths>().HasData(
                new PicturePaths
                {
                    PictureID = 1,
                    ProjectID = 1,
                    Path = "/images/Nonpawfit.jpg"
                },
                new PicturePaths
                {
                    PictureID = 2,
                    ProjectID = 2,
                    Path = "/images/Uno-Slides.jpg"
                },
                new PicturePaths
                {
                    PictureID = 3,
                    ProjectID = 2,
                    Path = "/images/Uno-Game1.jpg"
                }
                ,
                new PicturePaths
                {
                    PictureID = 4,
                    ProjectID = 2,
                    Path = "/images/Uno-Game2.jpg"
                }
                ,
                new PicturePaths
                {
                    PictureID = 5,
                    ProjectID = 2,
                    Path = "/images/Uno-Game3.jpg"
                }
                ,
                new PicturePaths
                {
                    PictureID = 6,
                    ProjectID = 2,
                    Path = "/images/Uno-Game4.jpg"
                }
                ,
                new PicturePaths
                {
                    PictureID = 7,
                    ProjectID = 2,
                    Path = "/images/Uno-Game5.jpg"
                },
                new PicturePaths
                {
                    PictureID = 8,
                    ProjectID = 1,
                    Path = "/images/NonPawFit-AdminDashboard.jpg"
                },
                new PicturePaths
                {
                    PictureID = 9,
                    ProjectID = 1,
                    Path = "/images/NonPawFit-AdminDashboardEvents.jpg"
                }
                );
        }
    }
}
