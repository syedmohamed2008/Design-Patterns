using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Factories
{
    public class NotificationFactoryProvider
    {
        private readonly EmailNotificationFactory _emailFactory;
        private readonly SmsNotificationFactory _smsFactory;

        public NotificationFactoryProvider(EmailNotificationFactory emailFactory, SmsNotificationFactory smsFactory)
        {
            _emailFactory = emailFactory;
            _smsFactory = smsFactory;
        }

        public INotificationFactory GetFactory(string type)
        {
            return type.ToLower() switch
            {
                "email" => _emailFactory,
                "sms" => _smsFactory,

                _ => throw new ArgumentException(
                    "Invalid notification type")
            };
        }
    }
}
