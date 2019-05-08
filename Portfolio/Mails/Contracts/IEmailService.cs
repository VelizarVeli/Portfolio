namespace Portfolio.Mails.Contracts
{
    public interface IEmailService
    {
        void Send(IEmailMessage emailMessage);
    }
}