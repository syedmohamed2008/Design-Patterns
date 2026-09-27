using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Notifications
{
    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }
}
