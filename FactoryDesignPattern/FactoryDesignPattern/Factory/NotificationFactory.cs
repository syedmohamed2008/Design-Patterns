using FactoryDesignPattern.Interface;
using FactoryDesignPattern.Notification;
using FactoryDesignPattern.Services;

namespace FactoryDesignPattern.Factory
{
    public class NotificationFactory : INotificationFactory
    {
        private readonly EmailService _emailService;
        private readonly SmsService _smsService;
        private readonly WhatsAppService _whatsAppService;

        public NotificationFactory(EmailService emailService, SmsService smsService, WhatsAppService whatsAppService)
        {
            _emailService = emailService;
            _smsService = smsService;
            _whatsAppService = whatsAppService;
        }

        public INotification CreateNotification(NotificationRequest request)
        {
            switch (request.Type.ToLower())
            {
                case "email":

                    return new EmailNotification(_emailService, request.Email);

                case "sms":

                    return new SmsNotification(_smsService, request.Mobile);

                case "whatsapp":

                    return new WhatsAppNotification(_whatsAppService, request.Mobile);

                default:

                    throw new ArgumentException(
                        $"Unsupported notification type: {request.Type}");
            }
        }
    }
}
