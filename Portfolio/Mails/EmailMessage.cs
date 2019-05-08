using System.ComponentModel.DataAnnotations;
using Portfolio.Mails.Contracts;

namespace Portfolio.Mails
{
    public class EmailMessage : IEmailMessage
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public string Subject { get; set; }

        [Required]
        public string Content { get; set; }
    }
}