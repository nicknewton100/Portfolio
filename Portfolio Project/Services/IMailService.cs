using Portfolio_Project.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_Project.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(ContactViewModel contactViewModel);
    }
}
