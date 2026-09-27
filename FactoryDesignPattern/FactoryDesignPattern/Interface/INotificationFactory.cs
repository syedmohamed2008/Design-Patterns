using FactoryDesignPattern.Notification;

namespace FactoryDesignPattern.Interface
{
    public interface INotificationFactory
    {
        INotification CreateNotification(NotificationRequest request);
    }
}
