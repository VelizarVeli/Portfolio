﻿using Microsoft.AspNetCore.Mvc;
using Portfolio.Mails;
using Portfolio.Mails.Contracts;

namespace Portfolio.Controllers
{
    public class MailController : Controller
    {
        private readonly IEmailService emailService;

        public MailController(IEmailService emailService)
        {
            ViewData["Message"] = "Your contact page.";
            this.emailService = emailService;
        }

        [HttpPost]
        public IActionResult SendMessage(EmailMessage message)
        {
            emailService.Send(message);
            return RedirectToAction("Index", "Home");
        }
    }
}