using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_Project.Models.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage ="Please enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter valid E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Company { get; set; }
        [DataType(DataType.PhoneNumber)]
        [StringLength(14,MinimumLength = 14,ErrorMessage = "Phone number invalid")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter a Message")]
        public string Message { get; set; }
    }
}
