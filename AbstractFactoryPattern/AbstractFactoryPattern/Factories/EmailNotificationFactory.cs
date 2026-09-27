using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Loggers;
using AbstractFactoryPattern.Notifications;

namespace AbstractFactoryPattern.Factories
{
    public class EmailNotificationFactory : INotificationFactory
    {
        private readonly EmailNotification _notification;
        private readonly EmailLogger _logger;

        public EmailNotificationFactory(EmailNotification notification, EmailLogger logger)
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
