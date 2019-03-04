using System.Collections.Generic;

namespace Portfolio.Mails.Contracts
{
    public interface IEmailService
    {
        void Send(EmailMessage emailMessage);
        List<EmailMessage> ReceiveEmail(int maxCount = 10);
    }
}