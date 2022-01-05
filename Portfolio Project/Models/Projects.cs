using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Portfolio_Project.Models
{
    public class Projects
    {
        [Key]
        public int ProjectID { get; set; }
        public string ThumbnailPath { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string About { get; set; }
        public string TechnicalSpecs { get; set; }
        public string GithubLink { get; set; }
        public string WebLink { get; set; }

        public ICollection<Project_Tags> Project_Tags { get; set; }
        public ICollection<PicturePaths> PicturePaths { get; set; }
    }
}
