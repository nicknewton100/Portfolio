using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Portfolio_Project.Models
{
    public class Project_Tags 
    { 
    
        public int Project_TagsID { get; set; }
        public int ProjectID { get; set; }
        public Projects Project { get; set; }
        public int TagID { get; set; }
        public Tags Tag { get; set; }
    }
}
