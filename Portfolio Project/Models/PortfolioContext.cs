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

        }
    }
}
