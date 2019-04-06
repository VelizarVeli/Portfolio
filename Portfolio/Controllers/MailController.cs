using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    [Route("api/[controller]")]
    public class MailController : Controller
    {
        private SmtpClient smtpClient;
        public MailController(SmtpClient smtpClient)
        {
            this.smtpClient = smtpClient;
        }


        //[HttpPost]
        //public async Task<IActionResult> Post()
        //{
        //    await this.smtpClient.SendMailAsync(new MailMessage(
        //        to: "velizar.velikov@gmail.com",
        //        subject: "Test message subject",
        //        body: "Test message body"
        //    ));

        //    return Ok("OK");
        //}

        protected override void Dispose(bool disposing)
        {
            this.smtpClient.Dispose();
            base.Dispose(disposing);
        }

    }
}