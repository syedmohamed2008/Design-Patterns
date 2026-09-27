using FactoryDesignPattern.Interface;
using FactoryDesignPattern.Services;

namespace FactoryDesignPattern.Notification
{
    public class EmailNotification : INotification
    {
        private readonly EmailService _emailService;
        private readonly string _email;

        public EmailNotification(EmailService emailService, string email)
        {
            _emailService = emailService;
            _email = email;
        }

        public void Send(string message)
        {
            _emailService.SendEmail(_email, message);
        }
    }
}
