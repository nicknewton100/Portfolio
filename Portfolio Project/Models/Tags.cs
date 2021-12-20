using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Portfolio_Project.Models
{
    public class Tags
    {
        [Key]
        public int TagID { get; set; }
        public string TagName { get; set; }
        public ICollection<Project_Tags> Project_Tags { get; set; }
    }
}
