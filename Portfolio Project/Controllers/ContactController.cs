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
        [HttpPost]
        public async Task<IActionResult> SendEmail(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                await mailService.SendEmailAsync(model);
                TempData["Sent"] = "Sent";
                return RedirectToAction("Index");
            }
            return View("Index", model);
        }
    }
}
