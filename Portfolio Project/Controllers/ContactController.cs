using Microsoft.AspNetCore.Mvc;
using Portfolio_Project.Models.ViewModels;
using Portfolio_Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_Project.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMailService mailService;
        public ContactController(IMailService mailService)
        {
            this.mailService = mailService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SendEmail(ContactViewModel model)
        {
            await mailService.SendEmailAsync(model);
            return RedirectToAction("Index");
        }
    }
}
