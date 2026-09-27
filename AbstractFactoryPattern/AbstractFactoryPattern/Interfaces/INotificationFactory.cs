namespace AbstractFactoryPattern.Interfaces
{
    public interface INotificationFactory
    {
        INotification CreateNotification();

        INotificationLogger CreateLogger();
    }
}
