using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Portfolio_Project.Controllers
{
    public class ProjectsController : Controller
    {
        private PortfolioContext context;
        public ProjectsController(PortfolioContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string sortby)
        {
            //sortby determines if the projects are sorted by tag or not
            if(sortby != null)
            {
                ViewBag.sortby = sortby;
                var tag = await context.Tags.Where(t => t.TagName.Equals(sortby))
                    .AsNoTracking()
                    .FirstOrDefaultAsync();
                var projects = await context.Projects
                    .Where(p => p.Project_Tags.Any(pt => pt.TagID == tag.TagID))
                    .Select(p => new Projects { Name = p.Name, ShortDesc = p.ShortDesc, ThumbnailPath = p.ThumbnailPath })
                    .AsNoTracking()
                    .ToListAsync();
                return View(projects);
            }
            else
            {
                var projects = await context.Projects
                    .Select(p => new Projects { Name = p.Name, ShortDesc = p.ShortDesc, ThumbnailPath = p.ThumbnailPath})
                    .AsNoTracking()
                    .ToListAsync();
                return View(projects);
            }
        }
        public async Task<IActionResult> Details(string name)
        {
            var project = await context.Projects.Include(p => p.PicturePaths)
                .Where(p => p.Name == name)
                .AsNoTracking()
                .FirstOrDefaultAsync();
            return View(project);
        }
    }
}
