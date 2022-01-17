﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portfolio_Project.Models;

namespace Portfolio_Project.Migrations
{
    [DbContext(typeof(PortfolioContext))]
    [Migration("20220117073612_updatedPortfolioProject")]
    partial class updatedPortfolioProject
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Portfolio_Project.Models.PicturePaths", b =>
                {
                    b.Property<int>("PictureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.HasKey("PictureID");

                    b.HasIndex("ProjectID");

                    b.ToTable("PicturePaths");

                    b.HasData(
                        new
                        {
                            PictureID = 1,
                            Path = "/images/Nonpawfit.jpg",
                            ProjectID = 1
                        },
                        new
                        {
                            PictureID = 2,
                            Path = "/images/Uno-Slides.jpg",
                            ProjectID = 2
                        },
                        new
                        {
                            PictureID = 3,
                            Path = "/images/Uno-Game1.jpg",
                            ProjectID = 2
                        },
                        new
                        {
                            PictureID = 4,
                            Path = "/images/Uno-Game2.jpg",
                            ProjectID = 2
                        },
                        new
                        {
                            PictureID = 5,
                            Path = "/images/Uno-Game3.jpg",
                            ProjectID = 2
                        },
                        new
                        {
                            PictureID = 6,
                            Path = "/images/Uno-Game4.jpg",
                            ProjectID = 2
                        },
                        new
                        {
                            PictureID = 7,
                            Path = "/images/Uno-Game5.jpg",
                            ProjectID = 2
                        },
                        new
                        {
                            PictureID = 8,
                            Path = "/images/NonPawFit-AdminDashboard.jpg",
                            ProjectID = 1
                        },
                        new
                        {
                            PictureID = 9,
                            Path = "/images/NonPawFit-AdminDashboardDonors.jpg",
                            ProjectID = 1
                        },
                        new
                        {
                            PictureID = 10,
                            Path = "/images/NonPawFit-AdminDashboardEmployees.jpg",
                            ProjectID = 1
                        },
                        new
                        {
                            PictureID = 11,
                            Path = "/images/NonPawFit-AdminDashboardMembership.jpg",
                            ProjectID = 1
                        },
                        new
                        {
                            PictureID = 12,
                            Path = "/images/NonPawFit-AdminDashboardEvents.jpg",
                            ProjectID = 1
                        },
                        new
                        {
                            PictureID = 13,
                            Path = "/images/NonPawFit-AdminDashboardNews.jpg",
                            ProjectID = 1
                        },
                        new
                        {
                            PictureID = 14,
                            Path = "/images/NonPawFit-AdminDashboardDonationCheckout.jpg",
                            ProjectID = 1
                        },
                        new
                        {
                            PictureID = 16,
                            Path = "/images/PortfolioHome.jpg",
                            ProjectID = 3
                        },
                        new
                        {
                            PictureID = 17,
                            Path = "/images/PortfolioProjects.jpg",
                            ProjectID = 3
                        },
                        new
                        {
                            PictureID = 18,
                            Path = "/images/PortfolioProjectsDetails.jpg",
                            ProjectID = 3
                        },
                        new
                        {
                            PictureID = 19,
                            Path = "/images/PortfolioContact.jpg",
                            ProjectID = 3
                        });
                });

            modelBuilder.Entity("Portfolio_Project.Models.Project_Tags", b =>
                {
                    b.Property<int>("Project_TagsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<int>("TagID")
                        .HasColumnType("int");

                    b.HasKey("Project_TagsID");

                    b.HasIndex("ProjectID");

                    b.HasIndex("TagID");

                    b.ToTable("Project_Tags");

                    b.HasData(
                        new
                        {
                            Project_TagsID = 1,
                            ProjectID = 1,
                            TagID = 1
                        },
                        new
                        {
                            Project_TagsID = 2,
                            ProjectID = 1,
                            TagID = 2
                        },
                        new
                        {
                            Project_TagsID = 3,
                            ProjectID = 1,
                            TagID = 3
                        },
                        new
                        {
                            Project_TagsID = 4,
                            ProjectID = 1,
                            TagID = 4
                        },
                        new
                        {
                            Project_TagsID = 5,
                            ProjectID = 1,
                            TagID = 5
                        },
                        new
                        {
                            Project_TagsID = 6,
                            ProjectID = 1,
                            TagID = 6
                        },
                        new
                        {
                            Project_TagsID = 7,
                            ProjectID = 1,
                            TagID = 11
                        },
                        new
                        {
                            Project_TagsID = 8,
                            ProjectID = 2,
                            TagID = 2
                        },
                        new
                        {
                            Project_TagsID = 9,
                            ProjectID = 2,
                            TagID = 7
                        },
                        new
                        {
                            Project_TagsID = 10,
                            ProjectID = 2,
                            TagID = 8
                        },
                        new
                        {
                            Project_TagsID = 11,
                            ProjectID = 3,
                            TagID = 1
                        },
                        new
                        {
                            Project_TagsID = 12,
                            ProjectID = 3,
                            TagID = 2
                        },
                        new
                        {
                            Project_TagsID = 13,
                            ProjectID = 3,
                            TagID = 3
                        },
                        new
                        {
                            Project_TagsID = 14,
                            ProjectID = 3,
                            TagID = 4
                        },
                        new
                        {
                            Project_TagsID = 15,
                            ProjectID = 3,
                            TagID = 5
                        },
                        new
                        {
                            Project_TagsID = 16,
                            ProjectID = 3,
                            TagID = 6
                        },
                        new
                        {
                            Project_TagsID = 17,
                            ProjectID = 3,
                            TagID = 11
                        });
                });

            modelBuilder.Entity("Portfolio_Project.Models.Projects", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GithubLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechnicalSpecs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbnailPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectID");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectID = 1,
                            About = "<p>Non-Paw-Fit Animal Rescue is a web application developed in ASP.Net Core with the purpose of being able to manage a nonprofit&#39;s user accounts(employee and customer), donations, memberships, committees, event calendar, and also generate formatted reports.</p> <p>&nbsp;</p> <p>This project was created in collaboration with 4 other group members at Greenville Technical College. I primarily worked on the backend of the application however, I have touched nearly every corner of this project.</p>",
                            GithubLink = "https://github.com/nicknewton100/NonProfitProject",
                            Name = "Non-Paw-Fit Animal Rescue",
                            ShortDesc = "<p>Non-Paw-Fit Animal Rescue is a database management website with logins, donations, users, etc.</p>",
                            TechnicalSpecs = "<ul><li>ASP.Net Core v3.0</li><li>C#</li><li>Entity Framework Core</li><li>MSSQL</li><li>HTML/CSS</li><li>Javascript</li><li>Visual Studio</li><li>Azure Portal</li><li>Github</li><li>Sourcetree</li><li>Fast Report</li></ul>",
                            ThumbnailPath = "/images/Nonpawfit.jpg",
                            WebLink = "http://www.nonpawfit.net"
                        },
                        new
                        {
                            ProjectID = 2,
                            About = "<p>Uno JavaFX is the game of Uno where you will face against an AI to see who will win. This game was created in collaboration with 2 other teammebers at greenville technical college using JavaFX. I mainly worked on the backend of the project creating all of the game logic and the AI however, some parts of the visuals I&nbsp;worked on as well.</p>",
                            GithubLink = "https://github.com/nicknewton100/Uno-JavaFX",
                            Name = "Uno JavaFX",
                            ShortDesc = "<p>Uno JavaFX is an Uno game where you face against an AI opponent.</p>",
                            TechnicalSpecs = "<ul><li>Java</li><li>JavaFX</li><li>CSS</li><li>IntelliJ</li></ul>",
                            ThumbnailPath = "/images/Uno-JavaFX.jpg",
                            WebLink = ""
                        },
                        new
                        {
                            ProjectID = 3,
                            About = "<p>Nicholasnewton.net is a personal portfolio project developed in ASP.NET Core that is used to showcase my skills/projects associated with programming as well as give information about myself.</p>",
                            GithubLink = "https://github.com/nicknewton100/Portfolio",
                            Name = "Portfolio",
                            ShortDesc = "<p>Nicholasnewton.net is a personal portfolio website used to showcase my skills/projects</p>",
                            TechnicalSpecs = "<ul><li>ASP.Net Core v3.1</li><li>C#</li><li>Entity Framework Core</li><li>MSSQL</li><li>HTML/CSS</li><li>Javascript</li><li>Visual Studio</li><li>Github</li><li>Sourcetree</li></ul>",
                            ThumbnailPath = "/images/PortfolioHomeThumbnail.jpg",
                            WebLink = "https://www.nicholasnewton.net/"
                        });
                });

            modelBuilder.Entity("Portfolio_Project.Models.Tags", b =>
                {
                    b.Property<int>("TagID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagID");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            TagID = 1,
                            TagName = "HTML"
                        },
                        new
                        {
                            TagID = 2,
                            TagName = "CSS"
                        },
                        new
                        {
                            TagID = 3,
                            TagName = "Javascript"
                        },
                        new
                        {
                            TagID = 4,
                            TagName = "C#"
                        },
                        new
                        {
                            TagID = 5,
                            TagName = "ASP.Net Core"
                        },
                        new
                        {
                            TagID = 6,
                            TagName = "MSSQL"
                        },
                        new
                        {
                            TagID = 7,
                            TagName = "Java"
                        },
                        new
                        {
                            TagID = 8,
                            TagName = "JavaFX"
                        },
                        new
                        {
                            TagID = 9,
                            TagName = "Python"
                        },
                        new
                        {
                            TagID = 10,
                            TagName = "C++"
                        },
                        new
                        {
                            TagID = 11,
                            TagName = "Github"
                        });
                });

            modelBuilder.Entity("Portfolio_Project.Models.PicturePaths", b =>
                {
                    b.HasOne("Portfolio_Project.Models.Projects", "Project")
                        .WithMany("PicturePaths")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Portfolio_Project.Models.Project_Tags", b =>
                {
                    b.HasOne("Portfolio_Project.Models.Projects", "Project")
                        .WithMany("Project_Tags")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Portfolio_Project.Models.Tags", "Tag")
                        .WithMany("Project_Tags")
                        .HasForeignKey("TagID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
