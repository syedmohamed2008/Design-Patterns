using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Loggers;
using AbstractFactoryPattern.Notifications;

namespace AbstractFactoryPattern.Factories
{
    public class SmsNotificationFactory : INotificationFactory
    {
        private readonly SmsNotification _notification;
        private readonly SmsLogger _logger;

        public SmsNotificationFactory(SmsNotification notification, SmsLogger logger)
        {
            _notification = notification;
            _logger = logger;
        }

        public INotification CreateNotification()
        {
            return _notification;
        }

        public INotificationLogger CreateLogger()
        {
            return _logger;
        }
    }
}
