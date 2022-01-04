using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Portfolio_Project.Models
{
    public class PicturePaths
    {
        [Key]
        public int PictureID { get; set; }
        public int ProjectID { get; set; }
        public Projects Project { get; set; }
        public string Path { get; set; }
        public bool IsThumbnail { get; set; }
    }
}
